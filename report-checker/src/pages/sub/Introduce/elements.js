import styled from 'styled-components'

export const Wrapper = styled.div`
  --width-left: 40%;
  width: 100%;
  height: 100%;
  display: flex;
  gap: calc(var(--gap-2) / 2);
`
export const IntroArea = styled.div`
  width: var(--width-left);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: var(--gap-1);
`
export const MemberAvatarsArea = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  gap: var(--gap-1);
  flex-wrap: wrap;
`
export const DetailsArea = styled.div`
  width: calc(100% - var(--width-left));
  height: 100%;
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
  overflow-y: auto;

  font-size: var(--font-size-medium);
  color: var(--color-9-7);
`
