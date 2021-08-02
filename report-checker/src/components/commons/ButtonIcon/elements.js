import styled, { css } from 'styled-components'

const sizeArr = {
  small: 'var(--img-size-small)',
  medium: 'var(--img-size-medium)',
  get default () {
    return this.small
  }
}
export const Button = styled.button`
  width: ${({ size }) => sizeArr[size] ?? sizeArr.default};
  aspect-ratio: 1;
  border: none;
  cursor: pointer;
  background: url(${({ icon }) => icon});
  background-size: 100% 100%;
  transition: var(--transition);

  ${({ icon, iconSelected }) =>
    icon &&
    iconSelected &&
    css`
      &:hover {
        background: url(${iconSelected});
        background-size: 100% 100%;
      }
    `}

  ${({ tooltip }) =>
    tooltip &&
    css`
      --arrow-size: 5px;
      --tooltip-width: 100px;
      --text-color: var(--color-5);
      --background-color: var(--color-2);
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
        background-color: var(--color-2);
        pointer-events: none;
        border: 1px solid var(--text-color);
        z-index: var(--index-2);
        opacity: 0;
      }

      &:before {
        content: '${tooltip}';
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
