import styled from 'styled-components'

export const Wrapper = styled.div`
  --content-left-width: 25%;
  width: 100%;
  height: 100%;
  display: flex;
  gap: var(--gap-2);
  text-align: center;
`
export const ContentLeft = styled.div`
  width: var(--content-left-width);
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
`
export const MainContent = styled.div`
  width: 100%;
  height: 65%;
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
`
export const ControlLeftArea = styled.div`
  display: flex;
  gap: var(--gap-1);
`
export const ContentRight = styled.div`
  width: calc(100% - var(--content-left-width));
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
`
export const ControlRightArea = styled.div`
  display: flex;
  justify-content: flex-end;
  gap: var(--gap-1);
`
