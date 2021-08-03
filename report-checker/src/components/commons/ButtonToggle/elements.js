import styled from 'styled-components'

const sizeArr = {
  small: 'var(--img-size-small)',
  medium: 'var(--img-size-medium)',
  get default () {
    return this.small
  }
}
export const Wrapper = styled.div`
  --size: ${({ size }) => sizeArr[size] ?? sizeArr.default};
  width: calc(var(--size) * 2);
  height: calc(var(--size) * 0.8);
  border-radius: var(--size);
  background-color: var(--color-6);
  box-shadow: 0 0 4px 0.5px var(--color-9) inset,
    0 0 10px 10px var(--color-7) inset, 0 0 3px var(--color-8);
  position: relative;

  & > * {
    width: var(--size);
    aspect-ratio: 1;
  }
`
export const Circle = styled.div`
  position: absolute;
  top: 50%;
  left: ${({ isOne }) => (isOne ? 0 : 50)}%;
  transform: translateY(-50%);
  transition: var(--transition);
  border-radius: 50%;

  &:before,
  &:after {
    content: '';
    position: absolute;
    inset: 0;
    border-radius: 50%;
  }
  &:before {
    background-color: var(--color-6);
    box-shadow: 0 0 5px var(--color-9) inset, 0 0 3px var(--color-1);
  }

  &:after {
    transition: var(--transition);
    background: url(${({ icon }) => icon});
    background-size: 90% 90%;
    background-position: center;
  }
`
