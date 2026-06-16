/**
 * Local Community Event Portal - Interactive Script
 * Addressing Tasks 5, 6, 7, 8, 9 & 10
 */

// Event fees lookup map
const EVENT_FEES = {
    cleanup: 0,
    food: 15,
    marathon: 25,
    art: 10,
    music: 20,
    science: 5
};

/**
 * Task 6: Validate Phone Number on blur
 */
function validatePhone() {
    const phoneInput = document.getElementById("userPhone");
    const phoneError = document.getElementById("phoneError");
    if (!phoneInput || !phoneError) return false;

    const val = phoneInput.value.trim();
    // Validate format like 123-456-7890 or a plain 10-digit number
    const regex = /^\d{3}-\d{3}-\d{4}$/;
    const simpleRegex = /^\d{10}$/;

    if (val === "") {
        phoneError.textContent = "Phone number is required.";
        phoneInput.style.borderColor = "var(--error-color)";
        return false;
    } else if (!regex.test(val) && !simpleRegex.test(val)) {
        phoneError.textContent = "Format must be 123-456-7890 or 10 digits.";
        phoneInput.style.borderColor = "var(--error-color)";
        return false;
    } else {
        phoneError.textContent = "";
        phoneInput.style.borderColor = "var(--success-color)";
        return true;
    }
}

/**
 * Task 6: Display event fee on dropdown change & Task 8: Save preference
 */
function handleEventChange(value) {
    const feeDisplay = document.getElementById("feeDisplay");
    if (feeDisplay) {
        if (value in EVENT_FEES) {
            const fee = EVENT_FEES[value];
            feeDisplay.textContent = fee === 0 ? "Free ($0.00)" : `$${fee}.00`;
            feeDisplay.style.color = "var(--success-color)";
            feeDisplay.style.backgroundColor = "var(--success-light)";
        } else {
            feeDisplay.textContent = "Select an event type to view fee";
            feeDisplay.style.color = "var(--primary-color)";
            feeDisplay.style.backgroundColor = "#f1f5f9";
        }
    }

    // Save selection to LocalStorage for returning users
    if (value) {
        localStorage.setItem("preferredEventType", value);
        console.log(`[Task 8] Preference saved to localStorage: ${value}`);
    }
}

/**
 * Task 6: Form Submission and On-Click Confirmation Dialog
 */
function confirmSubmit(event) {
    // Prevent default submission initially to handle custom workflows
    event.preventDefault();

    const form = document.getElementById("eventForm");
    const output = document.getElementById("formOutput");
    const phoneValid = validatePhone();

    // Check baseline HTML5 validation for all other fields
    if (!form.checkValidity() || !phoneValid) {
        form.reportValidity();
        output.className = "form-output error";
        output.textContent = "⚠️ Please fill out all required fields with valid input.";
        console.warn("[Task 10 Debug] Form validation failed.");
        return;
    }

    // If inputs are valid, show confirmation dialog
    const confirmed = confirm("Are you sure you want to register for this community event?");
    if (confirmed) {
        const name = document.getElementById("userName").value;
        const email = document.getElementById("userEmail").value;
        const eventSelect = document.getElementById("eventType");
        const eventText = eventSelect.options[eventSelect.selectedIndex].text;
        const date = document.getElementById("eventDate").value;

        // Display confirmation in <output> element (Task 5)
        output.className = "form-output success";
        output.innerHTML = `🎉 <strong>Submission Successful!</strong><br>Thank you, ${name}. You are registered for the <strong>${eventText}</strong> scheduled for ${date}. A confirmation email has been sent to ${email}.`;
        
        console.log(`[Task 10 Debug] Successful registration for ${name} (${email}) to event: ${eventText}`);

        // Reset the form values
        form.reset();

        // Reset character count
        document.getElementById("charCount").textContent = "0";

        // Pre-select preferences if they exist
        loadPreferences();
    } else {
        console.log("[Task 10 Debug] Registration submit cancelled by user.");
    }
}

/**
 * Task 6: Double-click to enlarge images
 */
function enlargeImage(imgElement) {
    const modal = document.getElementById("imageModal");
    const modalImg = document.getElementById("modalImg");
    const captionText = document.getElementById("modalCaption");

    if (modal && modalImg && captionText) {
        modal.style.display = "block";
        modalImg.src = imgElement.src;
        captionText.innerHTML = `${imgElement.alt} &mdash; <em>${imgElement.title}</em>`;
        console.log(`[Task 6] Image enlarged: ${imgElement.src}`);
    }
}

function closeModal() {
    const modal = document.getElementById("imageModal");
    if (modal) {
        modal.style.display = "none";
    }
}

/**
 * Task 7: Video media player status message
 */
function handleVideoCanPlay() {
    const videoStatus = document.getElementById("videoStatus");
    if (videoStatus) {
        videoStatus.textContent = "✔ Video ready to play";
        videoStatus.style.backgroundColor = "var(--success-light)";
        videoStatus.style.color = "var(--success-color)";
        console.log("[Task 7] Promo video ready: canplay event fired.");
    }
}

/**
 * Task 7: Warn users before leaving the page unfinished
 */
window.addEventListener("beforeunload", function(e) {
    const nameVal = document.getElementById("userName")?.value.trim();
    const emailVal = document.getElementById("userEmail")?.value.trim();
    const phoneVal = document.getElementById("userPhone")?.value.trim();
    const descVal = document.getElementById("eventDescription")?.value.trim();

    // Warn if any field contains text
    const formUnfinished = nameVal || emailVal || phoneVal || descVal;

    if (formUnfinished) {
        // Cancel the event and return a standard warning prompt
        e.preventDefault();
        e.returnValue = "You have filled out some form data. If you leave, your changes will be lost.";
        return e.returnValue;
    }
});

/**
 * Task 8: Retrieve preferences from localStorage
 */
function loadPreferences() {
    const preferred = localStorage.getItem("preferredEventType");
    if (preferred) {
        const select = document.getElementById("eventType");
        if (select) {
            select.value = preferred;
            handleEventChange(preferred);
            console.log(`[Task 8] Restored preferred event type from localStorage: ${preferred}`);
        }
    }
}

/**
 * Task 9: Geolocation finding nearest event
 */
function findLocation() {
    const locationOutput = document.getElementById("locationOutput");
    if (!locationOutput) return;

    locationOutput.className = "location-output visible";
    locationOutput.innerHTML = "🛰 Accessing GPS satellite coordinates...";

    if (!navigator.geolocation) {
        locationOutput.innerHTML = "❌ Geolocation is not supported by your browser.";
        console.warn("[Task 10 Debug] Geolocation API not supported.");
        return;
    }

    // High accuracy and timeout configuration options
    const geoOptions = {
        enableHighAccuracy: true,
        timeout: 8000,
        maximumAge: 0
    };

    navigator.geolocation.getCurrentPosition(
        function(position) {
            const lat = position.coords.latitude;
            const lon = position.coords.longitude;
            const acc = position.coords.accuracy;

            // City council landmarks coordinates
            const communityLocations = [
                { name: "Central Park Community Gardens", lat: 37.7749, lon: -122.4194 },
                { name: "Downtown Exhibition Center", lat: 37.7833, lon: -122.4167 },
                { name: "Sunset Recreation Hall", lat: 37.7600, lon: -122.4800 }
            ];

            let closest = communityLocations[0];
            let minDistance = Infinity;

            communityLocations.forEach(loc => {
                // Calculate simple Euclidean distance for localized coordinates
                const distance = Math.sqrt(Math.pow(loc.lat - lat, 2) + Math.pow(loc.lon - lon, 2));
                if (distance < minDistance) {
                    minDistance = distance;
                    closest = loc;
                }
            });

            locationOutput.innerHTML = `
                <strong>📍 Nearest Event Venue Discovered!</strong><br>
                Your Coordinates: <code>${lat.toFixed(5)}</code>, <code>${lon.toFixed(5)}</code><br>
                GPS Precision: <code>${acc.toFixed(1)} meters</code><br><br>
                🏛 <strong>Closest Venue:</strong> ${closest.name}<br>
                <em>Check the calendar details to view planned events at this location.</em>
            `;
            console.log(`[Task 9] Geolocation retrieved. Latitude: ${lat}, Longitude: ${lon}`);
        },
        function(error) {
            let errorMsg = "❌ Geolocation failed: ";
            switch(error.code) {
                case error.PERMISSION_DENIED:
                    errorMsg += "Access denied. Please grant location permissions in your browser bar.";
                    break;
                case error.POSITION_UNAVAILABLE:
                    errorMsg += "Position unavailable. Network or GPS hardware issue.";
                    break;
                case error.TIMEOUT:
                    errorMsg += "Request timed out. Signal weak or connection slow.";
                    break;
                default:
                    errorMsg += error.message;
            }
            locationOutput.innerHTML = errorMsg;
            console.warn(`[Task 9] Geolocation error: ${error.message} (Code: ${error.code})`);
        },
        geoOptions
    );
}

// Attach character count and preferences loader on DOM load
document.addEventListener("DOMContentLoaded", function() {
    // Character counter logic
    const textarea = document.getElementById("eventDescription");
    const charCount = document.getElementById("charCount");
    if (textarea && charCount) {
        textarea.addEventListener("input", function() {
            charCount.textContent = this.value.length;
        });
    }

    // Clear preferences handler
    const clearBtn = document.getElementById("clearPrefBtn");
    if (clearBtn) {
        clearBtn.addEventListener("click", function() {
            localStorage.clear();
            sessionStorage.clear();

            const select = document.getElementById("eventType");
            const feeDisplay = document.getElementById("feeDisplay");
            if (select) select.value = "";
            if (feeDisplay) {
                feeDisplay.textContent = "Select an event type to view fee";
                feeDisplay.style.color = "var(--primary-color)";
                feeDisplay.style.backgroundColor = "#f1f5f9";
            }

            alert("🗑 Your saved preferences have been deleted from local and session storage.");
            console.log("[Task 8] Storage cleared.");
        });
    }

    // Initial preference load
    loadPreferences();

    // Task 7: Show overlay card in the last 4 seconds of video playback
    const video = document.getElementById("promoVideo");
    const overlayCard = document.querySelector(".invitation-overlay-card");
    if (video && overlayCard) {
        video.addEventListener("timeupdate", function() {
            const timeLeft = video.duration - video.currentTime;
            if (!isNaN(timeLeft) && timeLeft <= 4) {
                overlayCard.classList.add("show");
            } else {
                overlayCard.classList.remove("show");
            }
        });
    }

    // Check for keyboard press listener inside feedback textarea for Task 10 Debug demo
    if (textarea) {
        textarea.addEventListener("keydown", function(e) {
            console.log(`[Task 10 Debug] Key pressed in textarea: "${e.key}" (Length: ${this.value.length + 1})`);
        });
    }
});