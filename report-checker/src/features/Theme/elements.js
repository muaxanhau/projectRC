import { createGlobalStyle } from 'styled-components'

export const ThemeDark = createGlobalStyle`
    :root {
        --color-1: rgb(52, 51, 52);
        --color-2: rgb(197, 202, 241);
        --color-3: rgb(52, 70, 112);
        --color-4: rgb(55, 0, 60);
        --color-5: rgb(18, 243, 200);
        --color-6: rgb(68, 67, 69);
        --color-7: rgb(52, 51, 52);
        --color-8: rgb(128, 128, 128);
        --color-9: rgb(197, 202, 241);
    }
`
export const ThemeLight = createGlobalStyle`
    :root {
        --color-1: rgb(22, 87, 231);
        --color-2: rgb(24, 63, 148);
        --color-3: rgb(55, 0, 60);
        --color-4: rgb(249, 59, 120);
        --color-5: rgb(18, 243, 200);
        --color-6: rgb(255, 255, 255);
        --color-7: rgb(230, 229, 243);
        --color-8: rgb(197, 202, 241);
        --color-9: rgb(52, 70, 112);
    }
`
