import { createGlobalStyle, css } from 'styled-components'

export const CustomeStyles = createGlobalStyle`
    ${({ appSizePercent, fontSizePercent, brightnessPercent }) => css`
      :root {
        --main-width: calc(var(--main-width-root) * ${appSizePercent});
        --main-height: calc(var(--main-height-root) * ${appSizePercent});

        --font-size-small: calc(
          var(--font-size-small-root) * ${fontSizePercent}
        );
        --font-size-medium: calc(
          var(--font-size-medium-root) * ${fontSizePercent}
        );
        --font-size-large: calc(
          var(--font-size-large-root) * ${fontSizePercent}
        );

        --img-size-small: calc(var(--img-size-small-root) * ${fontSizePercent});
        --img-size-medium: calc(
          var(--img-size-medium-root) * ${fontSizePercent}
        );
        --img-size-large: calc(var(--img-size-large-root) * ${fontSizePercent});

        body {
          filter: brightness(${brightnessPercent});
        }
      }
    `}
`
