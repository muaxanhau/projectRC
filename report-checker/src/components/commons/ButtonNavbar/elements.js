import styled, { css } from 'styled-components'
import { Shadow2 } from '../styles/shadow'

export const Button = styled.div`
  --font-size: var(--font-size-medium);
  --text-color: var(--color-8);
  --background-color: initial;
  --padding: 15px;
  width: calc(100% + var(--shadow-width-inset) * 2);
  padding: var(--padding);
  padding-right: calc(var(--padding) + var(--shadow-width-inset) * 2);
  background-color: var(--background-color);
  font-size: var(--font-size);
  font-family: var(--font-family-2);
  font-weight: var(--font-bold);
  border-top-left-radius: var(--border-radius-2);
  border-bottom-left-radius: var(--border-radius-2);
  position: relative;

  & > a {
    text-decoration: none;
    color: var(--text-color);
  }

  &:hover {
    ${({ active }) =>
      !active &&
      css`
        --text-color: var(--color-5);
      `}
  }

  ${({ icon, iconSelected }) =>
    icon &&
    css`
      --icon-size: calc(var(--font-size) * 1.4);
      padding-left: calc(var(--padding) * 2 + var(--icon-size));

      &:before {
        content: '';
        position: absolute;
        width: var(--icon-size);
        aspect-ratio: 1;
        transform: scale(1.5);
        transform-origin: center;
        background: url(${icon});
        background-size: cover;
        top: 50%;
        left: var(--padding);
        transform: translateY(-50%);
      }

      &:hover:before {
        background: url(${iconSelected});
        background-size: cover;
      }
    `};

  ${({ active }) =>
    active &&
    css`
      --text-color: var(--color-2-5);
      --background-color: var(--color-6-11);
      ${Shadow2}

      &:after {
        content: '';
        position: absolute;
        width: calc(var(--shadow-width-inset) * 2);
        height: 100%;
        background: linear-gradient(90deg, transparent, var(--color-6-11) 45%);
        top: 0;
        right: 0;
      }

      ${({ icon, iconSelected }) =>
        icon &&
        iconSelected &&
        css`
          &:before {
            background: url(${iconSelected});
            background-size: cover;
          }
        `}
    `}
`
