import { configureStore } from '@reduxjs/toolkit'
import createSagaMiddleware from 'redux-saga'
import rootSaga from './saga'
import resetStateReducer from '../features/ResetState/resetStateSlice'
import themeReducer from '../features/Theme/themeSlice'
import modifyStylesReducer from '../features/ModifyStyles/modifyStylesSlice'
import loadingReducer from '../features/Loading/loadingSlice'
import alertReducer from '../features/Alert/alertSlice'
import dataCollectionReducer from '../features/DataCollection/dataCollectionSlice'

const sagaMiddleware = createSagaMiddleware()

export const store = configureStore({
  reducer: {
    resetAllState: resetStateReducer,
    theme: themeReducer,
    modifyStyles: modifyStylesReducer,
    loading: loadingReducer,
    alert: alertReducer,
    dataCollection: dataCollectionReducer
  },
  middleware: [sagaMiddleware]
  // getDefaultMiddleware =>
  //   getDefaultMiddleware({ thunk: true, serializableCheck: false }).concat(
  //     sagaMiddleware
  //   )
})

sagaMiddleware.run(rootSaga)
