import styled, { css } from 'styled-components'
import { Tooltip } from '../styles/tooltip'

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

  ${Tooltip}
`
