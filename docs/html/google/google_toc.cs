<?cs # Table of contents for Dev Guide.

       For each document available in translation, add an localized title to this TOC.
       Do not add localized title for docs not available in translation.
       Below are template spans for adding localized doc titles. Please ensure that
       localized titles are added in the language order specified below.
?>

<ul id="nav">
  <li class="nav-section">
    <div class="nav-section-header empty"><a href="<?cs var:toroot ?>google/index.html">
        <span class="en">Overview</span>
      </a></div>
  </li>

  <li class="nav-section">
    <div class="nav-section-header"><a href="<?cs var:toroot ?>google/play-services/index.html">
      <span class="en">Google Play Services</span></a>
    </div>
    <ul>
      <li><a href="<?cs var:toroot?>google/play-services/setup.html">
          <span class="en">Setup</span></a>
      </li>

      <li><a href="<?cs var:toroot?>google/play-services/auth.html">
          <span class="en">Authentication</span></a>
      </li>

      <li><a href="<?cs var:toroot?>google/play-services/plus.html">
          <span class="en">Google+</span></a>
      </li>

      <li><a href="<?cs var:toroot?>google/play-services/maps.html">
          <span class="en">Google Maps</span></a>
      </li>

      <li id="gms-tree-list" class="nav-section">
        <div class="nav-section-header">
          <a href="<?cs var:toroot ?>reference/gms-packages.html">
            <span class="en">Reference</span>
          </a>
        <div>
      </li>

    </ul>
  </li>


  <li class="nav-section">
    <div class="nav-section-header"><a href="<?cs var:toroot ?>google/play/billing/index.html">
      <span class="en">Google Play In-app Billing</span></a>
    </div>
    <ul>
      <li><a href="<?cs var:toroot?>google/play/billing/billing_overview.html">
              <span class="en">Overview</span></a>
      </li>
      <li class="nav-section"><div class="nav-section-header"><a href="<?cs var:toroot?>google/play/billing/api.html">
              <span class="en">Version 3 API</span></a></div>
              <ul>
              <li><a href="<?cs var:toroot?>google/play/billing/billing_integrate.html">
              <span class="en">Implementing the API</span></a></li>
              <li><a href="<?cs var:toroot?>google/play/billing/billing_reference.html">
              <span class="en">Reference</span></a></li>
              </ul>
      </li>
      <li class="nav-section"><div class="nav-section-header"><a href="<?cs var:toroot?>google/play/billing/v2/api.html">
              <span class="en">Version 2 API</span></a></div>
              <ul>
              <li><a href="<?cs var:toroot?>google/play/billing/v2/billing_integrate.html">
              <span class="en">Implementing the API</span></a></li>
              <li><a href="<?cs var:toroot?>google/play/billing/v2/billing_subscriptions.html">
              <span class="en">Subscriptions</span></a></li>
              <li><a href="<?cs var:toroot?>google/play/billing/v2/billing_reference.html">
              <span class="en">Reference</span></a></li>
              </ul>
      </li>
      <li><a href="<?cs var:toroot?>google/play/billing/billing_best_practices.html">
              <span class="en">Security and Design</span></a>
      </li>
      <li><a href="<?cs var:toroot?>google/play/billing/billing_testing.html">
              <span class="en">Testing In-app Billing</span></a>
      </li>
      <li><a href="<?cs var:toroot?>google/play/billing/billing_admin.html">
              <span class="en">Administering In-app Billing</span></a>
      </li>
      <li><a href="<?cs var:toroot?>google/play/billing/versions.html">
              <span class="en">Version Notes</span></a>
      </li>
    </ul>
  </li>

  <li class="nav-section">
    <div class="nav-section-header"><a href="<?cs var:toroot ?>google/play/dist.html">
      <span class="en">Google Play Distribution</span></a>
    </div>
    <ul>
      <li><a href="<?cs var:toroot ?>google/play/filters.html">
          <span class="en">Filters on Google Play</span></a>
      </li>

      <li><a href="<?cs var:toroot ?>google/play/publishing/multiple-apks.html">
          <span class="en">Multiple APK Support</span></a>
      </li>
      <li><a href="<?cs var:toroot ?>google/play/expansion-files.html">
          <span class="en">APK Expansion Files</span></a>
      </li>
      <li class="nav-section">
        <div class="nav-section-header"><a href="<?cs var:toroot ?>google/play/licensing/index.html">
          <span class="en">Application Licensing</span></a>
        </div>
        <ul>
          <li><a href="<?cs var:toroot?>google/play/licensing/overview.html">
              <span class="en">Licensing Overview</span></a>
          </li>
          <li><a href="<?cs var:toroot?>google/play/licensing/setting-up.html">
              <span class="en">Setting Up for Licensing</span></a>
          </li>
          <li><a href="<?cs var:toroot?>google/play/licensing/adding-licensing.html">
              <span class="en">Adding Licensing to Your App</span></a>
          </li>
          <li><a href="<?cs var:toroot?>google/play/licensing/licensing-reference.html">
              <span class="en">Licensing Reference</span></a>
          </li>
        </ul>
      </li>
    </ul>
  </li>

  <li class="nav-section">
      <div class="nav-section-header"><a href="<?cs var:toroot ?>google/gcm/index.html">
        <span class="en">Google Cloud Messaging</span></a>
      </div>
      <ul>
        <li><a href="<?cs var:toroot?>google/gcm/gs.html">
            <span class="en">Getting Started</span></a>
        </li>
        <li><a href="<?cs var:toroot?>google/gcm/gcm.html">
            <span class="en">Architectural Overview</span></a>
        </li>
        <li><a href="<?cs var:toroot?>google/gcm/demo.html">
            <span class="en">Demo App Tutorial</span></a>
        </li>
        <li><a href="<?cs var:toroot?>google/gcm/adv.html">
            <span class="en">Advanced Topics</span></a>
        </li>
        <li><a href="<?cs var:toroot?>google/gcm/c2dm.html">
            <span class="en">Migration</span></a>
        </li>
        <li id="gcm-tree-list" class="nav-section">
          <div class="nav-section-header">
            <a href="<?cs var:toroot ?>reference/gcm-packages.html">
              <span class="en">Reference</span>
            </a>
          <div>
        </li>
      </ul>
  </li>


  <li class="nav-section">
    <div class="nav-section-header"><a href="<?cs var:toroot ?>google/backup/index.html">
      Android Backup Service</a>
    </div>
    <ul>
      <li><a href="<?cs var:toroot?>google/backup/signup.html">
          Register</a>
      </li>
    </ul>
  </li>

</ul>

<script type="text/javascript">
<!--
    buildToggleLists();
    changeNavLang(getLangPref());
//-->
</script>

