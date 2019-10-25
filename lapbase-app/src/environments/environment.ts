// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  LAPBASE_API_ADDRESS: 'https://localhost:5001/api/',
  AZURE_AD_CLIENTID: '8c692cb0-4826-466d-8b95-8805ee1e6a93',
  AZURE_AD_TENANTID: '2e833ca0-6a32-45e7-b968-1faae0218ea4',
  REDIRECT_URI: 'http://localhost:4200/Dashboard',
  POST_LOGOUT_REDIRECT_URI: 'http://localhost:4200',
  AUTHORITY: 'https://login.microsoftonline.com/2e833ca0-6a32-45e7-b968-1faae0218ea4',
  CONSENT_SCOPES: ['api://b9e4a478-e93e-4bea-bb73-cf23d5bfefe0/user_impersonation']
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
