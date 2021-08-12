import styled from 'styled-components'
import { Tooltip } from './../styles/tooltip'

export const Wrapper = styled.div`
  width: calc(
    var(--img-size-medium) * ${({ size }) => (size === 'large' ? 1 : 0.7)}
  );
  aspect-ratio: 1;
  border-radius: 50%;
  box-shadow: 0 0 6px 3px var(--color-9-6) inset;
  background: url(${({ image }) => image});
  background-size: 100% 100%;
  background-position: center;
  transition: var(--transition);

  &:hover {
    background-size: 120% 120%;
  }

  ${Tooltip}
`
