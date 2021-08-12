import { css } from 'styled-components'

export const Polygon1 = css`
  --x: 30px;
  --y: 35px;
  clip-path: polygon(
    calc(100% - var(--x)) 0,
    100% var(--y),
    100% 100%,
    0 100%,
    0 0
  );
`
