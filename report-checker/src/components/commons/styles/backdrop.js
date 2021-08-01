import { css } from 'styled-components'

export const Backdrop = css`
  position: fixed;
  inset: 0;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: rgba(0, 0, 0, 0.4);
  backdrop-filter: blur(5px);
  padding: var(--padding);
  z-index: 100;
  opacity: 0;
  animation: kf-opacity 0.25s 0s ease-in-out forwards;

  @keyframes kf-opacity {
    100% {
      opacity: 1;
    }
  }
`
