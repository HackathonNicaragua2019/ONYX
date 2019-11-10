'use strict';
var themeConfig = {
    init: false,
    options: {
        color: 'yellow-1',
        layout: 'wide'
    },
    colors: [
        {
            'Hex': '#f1be03',
            'colorName': 'yellow'
        },
        
    ],
    layouts: [
        {
            'Hex': '#7f7f7f',
            'layoutName': 'wide'
        },
        {
            'Hex': '#7f7f7f',
            'layoutName': 'boxed'
        }
    ],
    initialize: function () {
        var $this = this;
        if (this.init) return;

        $('head').append($('<link rel="stylesheet">').attr('href', '~/assets/js/theme-config.css'));
        
        $this.setColor('yellow-1');

        if ($.cookie('layout') != null) {
            $this.setLayout($.cookie('layout'));
        } else {
            $this.setLayout(themeConfig.options.layout);
        }

        if ($.cookie('init') == null) {
            $this.container.find('.theme-config-head a').click();
            $.cookie('init', true);
        }

        $this.init = true;
    },
    events: function () {
        var $this = this;
        $this.container.find('.theme-config-head a').click(function (e) {
            e.preventDefault();
            if ($this.container.hasClass('active')) {
                $this.container.animate({
                    right: '-' + $this.container.width() + 'px'
                }, 300).removeClass('active');
            } else {
                $this.container.animate({
                    right: '0'
                }, 300).addClass('active');
            }
        });
    },
    setColor: function (color) {
        var $this = this;
        var $colorConfigLink = $('#theme-config-link');
        if (this.isChanging) {
            return false;
        }
        $colorConfigLink.attr('href', '~/assets/css/theme-' + color + '.css');
        $.cookie('color', color);
    },
    setLayout: function (layout) {
        $('body').removeAttr('class');
        $('body').removeClass('wide').removeClass('boxed');
        $('body').addClass(layout);
        $.cookie('layout', layout);
        if($().waypoints) {
            setTimeout(function(){$.waypoints('refresh');},100);
        }
    },
    reset: function () {
        $.removeCookie('color');
        $.removeCookie('layout');
        window.location.reload();
    }
};

themeConfig.initialize();
