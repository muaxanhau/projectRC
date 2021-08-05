import styled from 'styled-components'

export const Wrapper = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: var(--gap-2);
`
export const RangeModifiedArea = styled.table`
  border: none;
`
export const TableBody = styled.tbody``
export const Item = styled.tr`
  text-align: left;
  vertical-align: baseline;
  font-family: var(--font-family-2);
`
export const Name = styled.th`
  padding: calc(var(--gap-2) / 2) calc(var(--gap-1) / 2);
  padding-left: 0;
  font-size: var(--font-size-medium);
  color: var(--color-9-6);
`
export const Content = styled.th`
  padding-left: calc(var(--gap-1) / 2);
  display: flex;
  align-items: center;
  gap: var(--gap-1);
  font-size: var(--font-size-small);
  color: var(--color-8);
`
export const ControlArea = styled.div`
  width: 100%;
  display: flex;
  justify-content: space-evenly;
`
