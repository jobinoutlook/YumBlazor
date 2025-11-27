﻿using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class IJSRuntimeExtentions
    {
        public static async Task<bool> ConfirmBox(this IJSRuntime jsRuntime, string message)
        {
            return await jsRuntime.InvokeAsync<bool>("confirm", message);
        }

        //----Toastr---
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "error", message);
        }
    }
}