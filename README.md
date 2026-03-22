# MemoryMatch - Premium Blazor WASM Game

MemoryMatch is a modern, high-performance memory card game built with **Blazor WebAssembly** and styled with **Tailwind CSS**. It features a premium design inspired by shadcn UI, complete with 3D animations, a customizable game timer, and full PWA support.

## ✨ Key Features

-   **Premium Aesthetics**: Red-branded theme with smooth 3D card flip animations and a clean, shadcn-inspired interface.
-   **Light/Dark Mode**: Automatic system preference detection and manual toggle with persistence via `localStorage`.
-   **Customizable Game Timer**: Test your speed with a countdown timer (default 30s) that can be adjusted in the settings.
-   **Progressive Web App (PWA)**: Installable on mobile and desktop devices with full manifest support and an integrated splash screen.
-   **Modern Stack**: Built using .NET 8, C#, and a tailored Tailwind CSS design system.
-   **Automated Deployment**: CI/CD pipeline via GitHub Actions, automatically rebuilding Tailwind CSS and deploying to Vercel.

## 🚀 Getting Started

To run the project locally, ensure you have the following installed:
-   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
-   [Node.js 20+](https://nodejs.org/) (for Tailwind CSS builds)

### 1. Clone the Repository
```bash
git clone https://github.com/your-username/blazor-wasm-memory-card-game.git
cd blazor-wasm-memory-card-game/BlazorWasm.MemoryCardsGameV2
```

### 2. Install Dependencies
```bash
npm install
```

### 3. Build & Run
First, compile the Tailwind CSS styles:
```bash
npm run build
```

Then, run the Blazor application:
```bash
dotnet watch run
```

The app will be available at `https://localhost:5001`.

## 🛠️ Tech Stack

-   **Frontend**: Blazor WebAssembly (.NET 8)
-   **Styling**: Tailwind CSS (Tailored HSL Design System)
-   **State Management**: C# Scoped Services (Theme Management)
-   **Branding**: Custom SVG Iconography
-   **Deployment**: GitHub Actions + Vercel

## 📄 License
This project is open-source and available under the MIT License.
