import { css } from 'styled-components'

export const Tooltip = css`
  ${({ tooltip }) =>
    tooltip &&
    css`
      --arrow-size: 5px;
      --tooltip-width: 100px;
      --text-color: var(--color-5-9);
      --background-color: var(--color-2-8);
      position: relative;

      &:hover {
        &:before, &:after {
          opacity: 1;
          transition: var(--transition);
          transition-delay: 1s;
        }
      }

      &:before, &:after {
        position: absolute;
        left: 50%;
        background-color: var(--background-color);
        pointer-events: none;
        border: 1px solid var(--text-color);
        z-index: var(--index-2);
        opacity: 0;
      }

      &:before {
        content: '${tooltip}';
        text-align: center;
        top: calc(100% + var(--arrow-size) - 1px);
        transform: translateX(calc(var(--arrow-size) * -2));
        width: var(--tooltip-width);
        padding: calc(var(--padding) * 0.7);
        color: var(--text-color);
        border-radius: var(--arrow-size);
      }

      &:after{
        content: '';
        top: 100%;
        transform: translateX(-50%);
        width: calc(var(--arrow-size) * 2);
        border-bottom: none;
        height: var(--arrow-size);
        clip-path: polygon(50% 0%, 0% 100%, 100% 100%);
      }
    `}
`
