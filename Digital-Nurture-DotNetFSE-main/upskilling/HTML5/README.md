# Local Community Event Portal

A lightweight, high-performance, and responsive browser-based community portal developed for local city councils to let residents register for events, find closest venues via GPS, and access basic support.

## 🚀 Features

- **Base HTML5 Semantic Layout**: Fast, SEO-optimized, and clean layout with structured navigation links.
- **Vibrant CSS3 Design**: Glassmorphic elements, elegant form grids, custom tables, glowing inputs, and a custom image viewer.
- **Real-Time Validations**: Instant character count indicators, event fee select change updates, and phone format checking on blur.
- **Offline-First Video Player**: Integrated invitation video trailer with canplay notifications, warning prompts for unsaved data on page leave, and loop support.
- **Client State Saving**: Automatic retention and pre-selection of preferred event types using `localStorage` with a button to wipe client storage.
- **High-Accuracy Geolocation**: Maps coordinates and determines the closest neighborhood facilities using high-precision GPS positioning.
- **Interactive Image Zoom**: Double-click any past event gallery image to open a glassmorphic modal zoom view.

---

## 💻 How to Run Locally

1. Open this project folder on your computer.
2. Double-click [index.html](index.html) to open it in Google Chrome (or right-click -> **Open with Chrome**).
3. Press `F12` or `Ctrl+Shift+I` to open Chrome Developer Tools and switch to the **Console** tab to watch debug logs in real-time as you interact with the forms and GPS!

---

## 🐙 How to Push to GitHub

Follow these steps to upload your repository to GitHub:

1. **Create a GitHub Repository**:
   - Go to [GitHub](https://github.com/) and log into your account.
   - Click the **New** button to create a new repository.
   - Name it `local-community-event-portal`.
   - Keep it **Public** (required for free hosting).
   - **Do NOT** check "Add a README", "Add .gitignore", or "Choose a license" (since we already have these files locally).
   - Click **Create repository**.

2. **Run Git Commands**:
   Open your terminal (PowerShell, Command Prompt, or VS Code terminal) in this folder and run the following commands:
   ```bash
   # 1. Rename default branch to main
   git branch -M main

   # 2. Link your local project to your new GitHub repository
   # (Replace '<your-github-username>' with your actual GitHub username)
   git remote add origin https://github.com/<your-github-username>/local-community-event-portal.git

   # 3. Push the files to GitHub
   git push -u origin main
   ```

---

## 🌐 How to Deploy to GitHub Pages (Free Hosting)

Once your code is pushed to GitHub, you can publish the site online for free:

1. On your GitHub repository page, click the **Settings** tab (gear icon at the top).
2. On the left sidebar, scroll down and click **Pages**.
3. Under the **Build and deployment** section:
   - Source: Select **Deploy from a branch** from the dropdown.
   - Branch: Click the dropdown showing `None`, select **main**, and keep the folder as `/ (root)`.
   - Click **Save**.
4. Wait about 1–2 minutes, then refresh the page.
5. GitHub will display a notification banner at the top of the Pages settings showing your live URL, e.g.:
   > **Your site is live at:** `https://<your-github-username>.github.io/local-community-event-portal/`

Click the link to test your live, mobile-friendly community portal!
