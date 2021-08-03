import { all } from 'redux-saga/effects'
import dataCollectionSaga from './../features/DataCollection/dataCollectionSaga'
import resetStateSaga from '../features/ResetState/resetStateSaga'

function * rootSaga () {
  yield all([resetStateSaga(), dataCollectionSaga()])
}

export default rootSaga
