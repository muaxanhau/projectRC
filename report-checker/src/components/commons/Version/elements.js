import styled from 'styled-components'

export const Wrapper = styled.p`
  --text-color: var(--color-8);
  font-size: var(--font-size-small);
  color: var(--text-color);
  transition: var(--transition);
  cursor: default;
  display: flex;
  align-items: center;

  &:hover {
    --text-color: var(--color-5);
  }
`
