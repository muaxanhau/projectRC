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

        --main-width: 970px;
        --main-height: 600px;

        --border-radius-1: 18px;
        --border-radius-2: 11px;

        --padding: 13px;
        --shadow-width-inset: 10px;
        --shadow-width-outset: 15px;

        --gap-1: 0.5rem;
        --gap-2: 1.1rem;

        --font-size-small: 0.8rem;
        --font-size-medium: 1.1rem;
        --font-size-large: 1.8rem;
        --font-family-2: roboto;
        --font-bold: 600;

        --img-size-small: 30px;
        --img-size-medium: 100px;
        --img-size-large: 160px;

        --transition: 250ms;

        --index-1: 100;
        --index-2: 200;
        --index-3: 300;
        --index-4: 400;
        --index-5: 500;
    }

    * {
        box-sizing: border-box;
        margin: 0;
        padding: 0;
    }

    body {
        width: 100vw;
        height: 100vh;
        background: linear-gradient(135deg, var(--color-3), var(--color-2), var(--color-2), var(--color-5));

        #root {
            width: 100%;
            height: 100%;
        }
    }
`
