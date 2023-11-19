import { Button } from 'primereact/button';
import { Dialog } from 'primereact/dialog';
import { ProgressSpinner } from 'primereact/progressspinner';
import { Home } from '../';
import { useCallbackMicrosoft } from '../../hooks';

/**
 * callback page for microsoft oauth
 * @returns {HTMLElement}
 */
function CallBackMicrosoft() {
  const { navigate, success, loading } = useCallbackMicrosoft();

  const header = () => {
    return (
      <div className='flex flex-row' style={{ width: '110%' }}>
        <Button label='Services' disabled text severity='info' />
        <Button label='Settings' onClick={() => navigate('/settings')} text severity='info' />
      </div>
    );
  };

  const showInfos = () => {
    return success ? (
      <div>
        <h1>Success !</h1>
        <span>
          You are connected to Microsoft's service. Go <a href='/home'>to the home page</a> to add
          new AREAs with this service.
        </span>
      </div>
    ) : (
      <div>
        <h1>Failure</h1>
        You weren't able to connect to Microsoft's service. Go{' '}
        <a href='/settings/services'>to the services page</a> to try again, connect with another
        account or to another service.
      </div>
    );
  };

  return (
    <Home publicPath='../../'>
      <Dialog
        header={header}
        style={{ minWidth: '30%', minHeight: '40%' }}
        visible
        onHide={() => navigate('/home')}>
        <Button
          style={{ marginLeft: -10 }}
          label='Microsoft'
          icon='pi pi-chevron-left'
          text
          severity='info'
          onClick={() => navigate('/settings/services')}
        />
        {loading ? <ProgressSpinner /> : showInfos()}
      </Dialog>
    </Home>
  );
}

export default CallBackMicrosoft;
