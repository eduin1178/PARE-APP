/** @type {import('tailwindcss').Config} */
module.exports = {
    prefix: 'tw-',
    fontFamily: {
        sans: ['Jost','Roboto', 'sans-serif'],
    },
    content: [
        "./**/*.{razor,html,cshtml}",
        "./node_modules/flowbite/**/*.js"
    ],
    theme: {
        extend: {},
    },
    plugins: [
        require('flowbite/plugin')
    ],
}