/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.{razor,html,cshtml}',
    './Components/**/*.{razor,html,cshtml}',
    './wwwroot/**/*.html',
  ],
  theme: {
    extend: {
      fontFamily: {
        primary: ['Roboto', 'sans-serif'],
        secondary: ['Montserrat', 'sans-serif'],
        accent: ['Chivo Mono', 'monospace'],
      },
      colors: {
        // Cool Professional palette
        background: '#1e293b', // bg-slate-800
        text: '#e7e5e4', // text-stone-200
        link: '#38bdf8', // text-sky-400
        accent1: '#2dd4bf', // text-teal-400
        accent2: '#4f46e5', // bg-indigo-600
        highlight: '#fcd34d', // text-amber-300

        // Warm Tech palette
        // background: '#1e293b',
        // text: '#d6d3d1',
        // link: '#fbbf24',
        // accent1: '#fb7185',
        // accent2: '#9333ea',
        // highlight: '#6ee7b7',

        // Monochorme Plus palette
        // background: '#1e293b',
        // text: '#e2e8f0',
        // link: '#94a3b8',
        // accent1: '#cbd5e1',
        // accent2: '#334155',
        // highlight: '#34d399',
      },
    },
  },
  plugins: [
    require('@tailwindcss/typography'),
  ],
}