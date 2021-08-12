import styled, { css } from 'styled-components'

export const Container = styled.div`
  --width-default: 200px;
  --arrow-size: 20px;
  width: ${({ width }) => width ?? 'var(--width-default)'};
  padding-top: var(--arrow-size);
`
export const Wrapper = styled.div`
  --pos-arrow: 20px;
  color: var(--color-9);
  background-color: var(--color-7-8);
  padding: calc(var(--padding) * 0.7);
  border-radius: var(--border-radius-2);
  border: 1px solid var(--color-9-4);
  position: relative;

  &:before,
  &:after {
    content: '';
    position: absolute;
    aspect-ratio: 3/2;
    bottom: 100%;
  }

  &:before {
    height: var(--arrow-size);

    ${({ arrowPosition }) =>
      arrowPosition === 'right'
        ? css`
            right: var(--pos-arrow);
            transform: scaleX(-1);
          `
        : css`
            left: var(--pos-arrow);
          `}
    background-color: var(--color-9-4);
    clip-path: polygon(0 0, 5px 100%, 100% 100%);
  }

  &:after {
    height: calc(var(--arrow-size) - 2px);

    ${({ arrowPosition }) =>
      arrowPosition === 'right'
        ? css`
            right: calc(var(--pos-arrow) + 1.5px);
            transform: scaleX(-1);
          `
        : css`
            left: calc(var(--pos-arrow) + 1.5px);
          `}
    background-color: var(--color-7-8);
    clip-path: polygon(0 0, 4.5px 100%, 100% 100%);
  }
`
