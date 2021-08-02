import { css } from 'styled-components'

export const FormLayoutCss = css`
  --size: 40px;
  clip-path: polygon(
    calc(100% - var(--size)) 0,
    100% var(--size),
    100% 100%,
    0 100%,
    0 0
  );
`
