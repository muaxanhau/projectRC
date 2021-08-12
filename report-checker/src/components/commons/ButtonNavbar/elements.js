import styled, { css } from 'styled-components'
import { Shadow2 } from '../styles/shadow'

export const Icon = styled.div`
  --icon: url(${({ icon }) => icon});
  --icon-selected: url(${({ iconSelected }) => iconSelected});
  position: absolute;
  left: calc(var(--padding) + var(--font-size) / 2);
  top: 50%;
  transform: translate(-50%, -50%);
  width: var(--font-size);
  aspect-ratio: 1;
  background: var(--icon);
  background-size: 100% 100%;
  transition: var(--transition);
`
export const Text = styled.p`
  white-space: nowrap;
  overflow: hidden;
`
export const Button = styled.div`
  --background-color: transparent;
  --font-size: var(--font-size-medium);
  --text-color: var(--color-8);
  font-size: var(--font-size);
  font-family: var(--font-family-2);
  font-weight: var(--font-bold);
  color: var(--text-color);
  border-top-left-radius: var(--border-radius-2);
  border-bottom-left-radius: var(--border-radius-2);
  padding: var(--padding);
  background-color: var(--background-color);
  cursor: pointer;
  position: relative;
  transition: max-width var(--transition), padding var(--transition);

  ${({ isOpen }) =>
    isOpen
      ? css`
          padding-left: calc(var(--padding) * 2 + var(--font-size));
          max-width: calc(var(--main-height) * 0.25);
          transition-delay: var(--transition);
        `
      : css`
          padding-left: calc(var(--padding) + var(--font-size));
          max-width: 0;

          & > ${Icon} {
            width: 60%;
          }
        `};

  ${({ isActive }) =>
    isActive
      ? css`
          --text-color: var(--color-2-5);
          --background-color: var(--color-6-11);

          & > ${Icon} {
            background: var(--icon-selected);
            background-size: 100% 100%;
          }

          ${Shadow2}

          &:before, &:after {
            content: '';
            position: absolute;
            height: 100%;
            top: 0;
            right: 0;
            transform: translateX(20px);
          }
          &:before {
            width: calc(40px + var(--padding));
            background-color: var(--color-6-11);
            clip-path: polygon(20px 0, 100% 0, 100% 100%, 20px 100%);
            ${Shadow2}
          }
          &:after {
            width: 20px;
            transform: translateX(20px);
            background: linear-gradient(
              90deg,
              transparent,
              var(--color-6-11) 45%
            );
          }
        `
      : css`
          &:hover {
            --text-color: var(--color-5);

            & > ${Icon} {
              background: var(--icon-selected);
              background-size: 100% 100%;
            }
          }
        `}
`
