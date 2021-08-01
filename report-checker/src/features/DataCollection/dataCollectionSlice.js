import { createSlice } from '@reduxjs/toolkit'

const initialState = {
  value: {
    itemTotals: [],
    itemHistory: {
      current: -1,
      track: []
    }
  },
  status: 'idle'
}

export const dataCollectionSlice = createSlice({
  name: 'dataCollection',
  initialState,
  reducers: {
    setDefaultItemTotals: (state, action) => {
      return {
        ...state,
        value: {
          ...state.value,
          itemTotals: action.payload.items
        }
      }
    },
    addDataToItemTotals: (state, action) => {
      const { items } = action.payload
      const rootItems = JSON.parse(JSON.stringify(state.value.itemTotals))

      items.forEach(item => {
        const itemTmp = rootItems.find(element => element.name === item.name)
        if (itemTmp) {
          item.colors.forEach(color => {
            const colorTmp = itemTmp.colors.find(
              element => element.name === color.name
            )
            if (colorTmp) {
              color.sizes.forEach(size => {
                const sizeTmp = colorTmp.sizes.find(
                  element => element.name === size.name
                )
                if (sizeTmp) {
                  sizeTmp.quantity =
                    parseInt(sizeTmp.quantity) + parseInt(size.quantity)
                } else {
                  colorTmp.sizes.push(size)
                }
              })
            } else {
              itemTmp.colors.push(color)
            }
          })
        } else {
          rootItems.push(item)
        }
      })
      return {
        ...state,
        value: {
          ...state.value,
          itemTotals: rootItems
        }
      }
    },
    clearItemTotals: state => {
      return {
        ...state,
        value: {
          ...state.value,
          itemTotals: []
        }
      }
    },
    pushHistory: state => {
      const history = JSON.parse(JSON.stringify(state.value.itemHistory))
      if (!state.value.itemTotals.length && history.current >= 0) {
        if (!history.track[history.current].length) {
          return state
        }
      }

      if (history.current < history.track.length - 1) {
        history.track.splice(
          history.current + 1,
          history.track.length - history.current
        )
      }
      history.current++
      history.track.push(state.value.itemTotals)

      return {
        ...state,
        value: {
          ...state.value,
          itemHistory: history
        }
      }
    },
    undoItemTotals: state => {
      const history = JSON.parse(JSON.stringify(state.value.itemHistory))
      const prevIndex = history.current - 1
      if (prevIndex < 0) {
        return state
      }
      const prevItems = history.track[prevIndex]
      return {
        ...state,
        value: {
          itemHistory: {
            ...state.value.itemHistory,
            current: prevIndex
          },
          itemTotals: prevItems
        }
      }
    },
    redoItemTotals: state => {
      const history = JSON.parse(JSON.stringify(state.value.itemHistory))
      const nextIndex = history.current + 1
      if (nextIndex >= history.track.length) {
        return state
      }
      const nextItems = history.track[nextIndex]
      return {
        ...state,
        value: {
          itemHistory: {
            ...state.value.itemHistory,
            current: nextIndex
          },
          itemTotals: nextItems
        }
      }
    }
  }
})

export const {
  setDefaultItemTotals,
  addDataToItemTotals,
  clearItemTotals,
  pushHistory,
  undoItemTotals,
  redoItemTotals
} = dataCollectionSlice.actions

export const selectDataCollection = state => state.dataCollection.value

export default dataCollectionSlice.reducer
