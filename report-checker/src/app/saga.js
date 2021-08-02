import { all } from 'redux-saga/effects'
import dataCollectionSaga from './../features/DataCollection/dataCollectionSaga'
import resetAllStateSaga from '../features/ResetAllState/resetAllStateSaga'

function * rootSaga () {
  yield all([resetAllStateSaga(), dataCollectionSaga()])
}

export default rootSaga
