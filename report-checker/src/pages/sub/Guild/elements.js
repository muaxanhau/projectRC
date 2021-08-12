import styled from 'styled-components'

export const Container = styled.div`
  width: 100%;
  height: 100%;
  overflow-y: auto;
  display: flex;
  flex-direction: column;
  gap: calc(var(--gap-2) * 4);
`
export const Wrapper = styled.div`
  width: 100%;
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
`
export const Content = styled.div`
  display: flex;
  gap: var(--gap-1);
  color: var(--color-9-7);
`
export const Image = styled.img`
  width: 60%;
  object-fit: scale-down;
`
export const TextArea = styled.div`
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
`
