import styled, { css } from 'styled-components'

const sizeArr = {
  small: 'var(--font-size-small)',
  medium: 'var(--font-size-medium)',
  large: 'var(--font-size-large)',
  get default () {
    return this.medium
  }
}
const fontWeightArr = {
  small: 100,
  medium: 'var(--font-bold)',
  large: 'var(--font-bold)',
  get default () {
    return this.medium
  }
}
export const Button = styled.button`
  --text-color: var(--color-9-7);
  --background-color: var(--color-7-10);
  width: ${({ width }) => width ?? 'auto'};
  white-space: nowrap;
  padding: calc(var(--padding) * 0.7);
  color: var(--text-color);
  background-color: var(--background-color);
  border: none;
  font-size: ${({ size }) => sizeArr[size] ?? sizeArr.default};
  font-weight: ${({ size }) => fontWeightArr[size] ?? fontWeightArr.default};
  position: relative;

  &:before {
    content: '';
    position: absolute;
    width: 100%;
    height: 14%;
    left: 0;
    bottom: 0;
    background-color: var(--color-4);
    opacity: 0;
  }

  ${({ active }) =>
    active === true &&
    css`
      --text-color: var(--color-7);
      --background-color: var(--color-2-9);
      &:before {
        opacity: 1;
      }
    `}

  &:hover {
    --text-color: var(--color-5);
    --background-color: var(--color-1-10);
    transition: var(--transition);

    &:before {
      opacity: 1;
      transition: var(--transition);
    }
  }
`
