const value = document.querySelector("#value");
const input = document.querySelector("#backgroundBrightness");
const thumbBackground = document.getElementById("#thumbBackground");

value.textContent = `${input.value}%`;
thumbBackground.style.filter = `brightness(${input.value}%)`;

input.addEventListener("input", (event) => {
  value.textContent = `${event.target.value}%`;
  thumbBackground.style.filter = `brightness(${event.target.value}%)`;
});
