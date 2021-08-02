import styled, { css } from 'styled-components'
import { Autofill } from '../styles/input'

const sizeArr = {
  small: 'var(--font-size-small)',
  medium: 'var(--font-size-medium)',
  large: 'var(--font-size-large)',
  get default () {
    return this.medium
  }
}
export const Wrapper = styled.div`
  --width-default: 150px;
  --text-color: var(--color-9);
  --background-color: var(--color-6);
  --shadow: 0 0 2px var(--color-9);
  --padding: 0.5rem;

  & > input {
    width: ${({ width }) => width ?? 'var(--width-default)'};
    color: var(--text-color);
    background-color: var(--background-color);
    box-shadow: var(--shadow);
    transition: var(--transition);
    border: 1px solid var(--color-8);
    font-size: ${({ size }) => sizeArr[size] ?? sizeArr.default};
    padding: var(--padding);
    ${({ icon, size }) =>
      icon &&
      css`
        padding-left: calc(
          var(--padding) * 2 + ${sizeArr[size] ?? sizeArr.default}
        );
      `};

    &::placeholder {
      opacity: 0.5;
      color: var(--text-color);
      font-size: 80%;
    }

    &:focus,
    &:hover {
      outline: none;
      border-color: var(--color-1);
    }

    ${Autofill}
  }

  ${({ icon }) =>
    icon &&
    css`
      position: relative;

      &:before {
        content: '';
        position: absolute;
        background: url(${({ icon }) => icon});
        background-size: 100% 100%;
        width: ${({ size }) => sizeArr[size] ?? sizeArr.default};
        aspect-ratio: 1;
        top: 50%;
        left: var(--padding);
        transform: translateY(-50%);
      }
    `}
`
