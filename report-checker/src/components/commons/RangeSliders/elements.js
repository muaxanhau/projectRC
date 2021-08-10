import styled from 'styled-components'
import { Tooltip } from './../styles/tooltip'

export const Range = styled.input`
  --width-default: 200px;
  --height: var(--scrollbar-width);
  width: ${({ width }) => width ?? 'var(--width-default)'};
  height: var(--height);
  appearance: none;
  outline: none;
  background: var(--color-8-10);
  border-radius: var(--height);
  opacity: 0.6;
  transition: var(--transition);
  cursor: pointer;

  ${({ enableTooltip }) => enableTooltip && Tooltip}

  &:hover {
    opacity: 1;
  }

  &::-webkit-slider-thumb {
    appearance: none;
    width: 15%;
    height: var(--height);
    border-radius: var(--height);
    background: var(--color-2-8);
    cursor: pointer;

    &:hover {
      background: var(--color-4-5);
    }
  }
`
