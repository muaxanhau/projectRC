import styled from 'styled-components'

const sizeArr = {
  small: 'calc(var(--font-size-small) * 1.2)',
  medium: 'calc(var(--font-size-medium) * 1.2)',
  large: 'calc(var(--font-size-large) * 1.2)',
  get default () {
    return this.small
  }
}
export const Wrapper = styled.div`
  --text-color: var(--color-8);
  font-size: ${({ size }) => sizeArr[size] ?? sizeArr.default};
  font-weight: var(font-bold);
  color: var(--text-color);
  cursor: default;
  text-shadow: 0px 2px 5px var(--color-3);
  display: flex;
  justify-content: center;
  align-items: center;

  &:hover {
    --text-color: var(--color-5);
    transition: var(--transition);
  }
`
