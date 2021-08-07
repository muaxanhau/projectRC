import { createGlobalStyle } from 'styled-components'

export const GlobalStyle = createGlobalStyle`
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
        --color-10: rgb(68, 67, 69);
        --color-11: rgb(52, 51, 52);
        
        --main-width-root: 970px;
        --main-height-root: 600px;

        --border-radius-1: 18px;
        --border-radius-2: 11px;

        --padding: 13px;
        --shadow-width-inset: 10px;
        --shadow-width-outset: 15px;

        --gap-1: 0.5rem;
        --gap-2: 1.1rem;

        --font-size-small-root: 13px;
        --font-size-medium-root: 18px;
        --font-size-large-root: 29px;
        --font-family-2: roboto;
        --font-bold: 600;

        --img-size-small-root: 30px;
        --img-size-medium-root: 70px;
        --img-size-large-root: 180px;

        --transition: 250ms;

        --index-1: 100;
        --index-2: 200;
        --index-3: 300;
        --index-4: 400;
        --index-5: 500;

        --scrollbar-width: 10px;
    }

    * {
        box-sizing: border-box;
        margin: 0;
        padding: 0;
    }

    body {
        width: 100vw;
        height: 100vh;
        overflow: hidden;

        #root {
            width: 100%;
            height: 100%;
        }
    }


    ::-webkit-scrollbar {
        width: var(--scrollbar-width);
    }
    ::-webkit-scrollbar-track {
        background-color: var(--color-7-10);
        border-radius: var(--scrollbar-width);
    }
    ::-webkit-scrollbar-thumb {
        background-color: var(--color-8);
        border-radius: calc(var(--scrollbar-width) / 2);
    }
    ::-webkit-scrollbar-thumb:hover {
        background-color: var(--color-9-4);
    }
`
