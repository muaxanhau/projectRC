import styled from 'styled-components'
import { Tooltip } from './../../../components/commons/styles/tooltip'

export const Wrapper = styled.div`
  --width-left: 40%;
  width: 100%;
  height: 100%;
  display: flex;
  gap: var(--gap-2);
`
export const IntroArea = styled.div`
  width: var(--width-left);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: var(--gap-2);
`
export const MemberAvatarsArea = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  gap: var(--gap-1);
  flex-wrap: wrap;
`
export const Avatar = styled.div`
  width: var(--img-size-medium);
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
export const DetailsArea = styled.div`
  width: calc(100% - var(--width-left));
  height: 100%;
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
  overflow-y: auto;

  font-size: var(--font-size-medium);
  color: var(--color-9-6);
`
