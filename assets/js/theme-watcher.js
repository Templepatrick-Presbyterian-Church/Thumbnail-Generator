if (
  window.matchMedia &&
  window.matchMedia("(prefers-color-scheme: light)").matches
) {
  document.documentElement.setAttribute("data-bs-theme", "light");
}

window
  .matchMedia("(prefers-color-scheme: dark)")
  .addEventListener("change", (event) => {
    console.log(
      "---------------------------- Changing Colour Scheme ----------------------------"
    );
    const newColorScheme = event.matches ? "dark" : "light";
    document.documentElement.setAttribute("data-bs-theme", newColorScheme);
  });
