# Installation and Configuration Guide

This guide walk you through installing the GitHub Copilot extensions, authenticating your license, and configuring settings.

---

## 1. Prerequisites
Before installation, ensure you have:
1. **GitHub Account**: A valid account on GitHub.com.
2. **Copilot License**: An active subscription or trial. This can be:
   - *Copilot Individual*: Self-funded subscription.
   - *Copilot Business / Enterprise*: Allocated to your GitHub account by your organization.
3. **Supported IDE**: Install the latest stable version of VS Code, Visual Studio (2022 or higher), or a JetBrains IDE (IntelliJ IDEA, PyCharm, WebStorm, Rider, etc.).

---

## 2. Installation in VS Code (Visual Studio Code)

1. Open Visual Studio Code.
2. Open the Extensions view by clicking the Extensions icon in the Activity Bar on the side of VS Code or using the keyboard shortcut `Ctrl + Shift + X` (Windows/Linux) or `Cmd + Shift + X` (macOS).
3. In the search box, type `GitHub Copilot`.
4. Locate the **GitHub Copilot** extension published by GitHub and click **Install**.
5. Locate the **GitHub Copilot Chat** extension and click **Install** (this is usually installed automatically alongside the main extension, but verify it is active).
6. A prompt will appear in the bottom-right corner asking you to sign in to GitHub. Click **Sign in to GitHub**.
7. Your web browser will open. Sign in to your GitHub account and authorize the application access.
8. Once authorized, return to VS Code. The Copilot icon (a small robot face) should appear in the Status Bar in the bottom-right corner.

---

## 3. Installation in JetBrains IDEs (PyCharm, IntelliJ, Rider, etc.)

1. Open your JetBrains IDE.
2. On the top menu bar, navigate to **File** > **Settings** (Windows/Linux) or **PyCharm/IntelliJ** > **Preferences** (macOS).
3. In the left-hand menu, select **Plugins**.
4. Click the **Marketplace** tab at the top and search for `GitHub Copilot`.
5. Select the plugin and click **Install**.
6. If prompted, restart the IDE to apply changes.
7. After restarting, navigate to **Tools** > **GitHub Copilot** > **Login to GitHub**.
8. A dialog box will display a 8-character **Device Code**. Click **Copy and Open**.
9. Your browser will open. Paste the device code, click **Continue**, and authorize access for the plugin.
10. Return to the IDE. The Copilot tool window will now be available, and you will see completions in the editor.

---

## 4. Installation in Visual Studio (2022+)

1. Launch Visual Studio.
2. Click **Extensions** > **Manage Extensions** in the top menu.
3. In the Manage Extensions window, select **Online** in the left panel and search for `GitHub Copilot`.
4. Click **Download**. Close Visual Studio to allow the VSIX Installer to run and apply the extension.
5. Relaunch Visual Studio.
6. Ensure you are signed in to Visual Studio with the GitHub account that holds your Copilot subscription:
   - Go to **File** > **Account Settings**.
   - Under **Personalization Account**, add or authenticate your GitHub credentials.

---

## 5. Configuring Account-Level Settings on GitHub

To configure privacy and recommendation filters, log in to GitHub.com, click your profile picture in the top-right corner, select **Settings**, and click **Copilot** in the left sidebar.

- **Suggestions matching public code**: 
  - *Blocked*: Prevents Copilot from recommending code that matches public repositories on GitHub (reduces intellectual property/licensing risk).
  - *Allowed*: Enables Copilot to suggest code that matches public code. Use this only if you do not have strict licensing constraints.
- **Allow GitHub to use my code snippets for product improvements**:
  - Unchecking this option ensures that your telemetry and prompt data are not stored or processed to retrain public models. (Enterprise licenses automatically block snippet retention).
