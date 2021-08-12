import styled from 'styled-components'

export const Wrapper = styled.div`
  --width-default: 200px;
  --space-between: 4px;
  --pieace-size: 5px;
  width: 100%;
  padding: 3px;
  position: relative;

  &:before,
  &:after {
    content: '';
    position: absolute;
    width: calc(
      (${({ width }) => width ?? 'var(--width-default)'} - var(--space-between)) /
        2
    );
    height: 100%;
    top: 0;
    background-color: var(--color-9-8);
    clip-path: polygon(
      0 0,
      calc(100% - var(--pieace-size) / 2) 0,
      100% calc(var(--pieace-size) / 2),
      100% 100%,
      calc(100% - var(--pieace-size)) 50%,
      var(--pieace-size) 50%
    );
  }

  &:before {
    right: calc(50% + var(--space-between) / 2);
  }

  &:after {
    transform: scaleX(-1);
    left: calc(50% + var(--space-between) / 2);
  }
`
