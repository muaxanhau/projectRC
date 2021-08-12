import styled, { css } from 'styled-components'
import { Tooltip } from './../../../components/commons/styles/tooltip'

export const Table = styled.table`
  --font-size: calc(var(--font-size-medium) * 0.8);
  --header-height: 35px;
  --padding-box: calc(var(--padding) / 2);
  width: 100%;
  height: 100%;
  font-size: var(--font-size);

  ${({ columnWidth }) =>
    columnWidth.map(
      (width, index) => css`
        & > * > * > *:nth-child(${index + 1}) {
          width: ${width};
        }
      `
    )};
`
export const Header = styled.thead`
  display: table;
  width: calc(100% - var(--scrollbar-width));
  height: var(--header-height);
  background-color: var(--color-8-9);

  & > tr {
    height: 100%;
  }
`
export const ColumnTitle = styled.th`
  font-family: var(--font-family-2);
  color: var(--color-2-5);
  word-break: break-all;

  &:not(:first-child) {
    cursor: pointer;
  }

  ${Tooltip}
`
export const Column = styled.td`
  padding: var(--padding-box);
  text-align: center;
  word-break: break-all;
`
export const Row = styled.tr`
  display: table;
  width: 100%;
`
export const Body = styled.tbody`
  height: calc(100% - var(--header-height));
  background-color: var(--color-6-10);
  display: block;
  overflow-y: scroll;
  overflow-x: hidden;

  & > ${Row} {
    &:nth-child(odd) {
      color: var(--color-9-7);
      background-color: var(--color-7-11);
    }

    &:nth-child(even) {
      color: var(--color-9-7);
      background-color: var(--color-6-10);
    }

    --color-c-1: rgb(159, 235, 213);
    --color-c-2: rgb(160, 222, 246);
    --color-c-3: rgb(201, 221, 244);

    &:nth-child(1) {
      color: var(--color-9);
      background-color: var(--color-c-1);
    }
    &:nth-child(2) {
      color: var(--color-9);
      background-color: var(--color-c-2);
    }
    &:nth-child(3) {
      color: var(--color-9);
      background-color: var(--color-c-2);
    }
    &:nth-child(4) {
      color: var(--color-9);
      background-color: var(--color-c-2);
    }
    &:nth-child(5) {
      color: var(--color-9);
      background-color: var(--color-c-3);
    }
  }
`
export const SortIcon = styled.img`
  width: var(--font-size);
  aspect-ratio: 1;
  object-fit: cover;
  margin-left: calc(var(--font-size) / 4);
`
export const StatusIcon = styled.img`
  width: var(--font-size);
  aspect-ratio: 1;
  object-fit: cover;
`
