using BlazorKendoUI.Shared;
using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorKendoUI
{
    public static class KendoUIInterop
    {
        static Dictionary<string, Dictionary<string, Action>> handlers = new Dictionary<string, Dictionary<string, Action>>();

        public static bool InitModel(object model, string widgetName)
        {
            return RegisteredFunction.Invoke<bool>($"KendoUI.Interop.{widgetName}.Init", new[] { model });
        }

        public static bool UpdateModel(object model, string widgetName)
        {
            return RegisteredFunction.Invoke<bool>($"KendoUI.Interop.{widgetName}.Update", new[] { model });
        }

        public static void DisposeModel(string id)
        {
            CleanComponentHandlers(id);

            RegisteredFunction.Invoke<bool>("KendoUI.Interop.Widget.Dispose", new[] { id });
        }

        public static void RegisterHandler(string id, string eventName, Action handler)
        {
            if (!handlers.ContainsKey(id))
            {
                handlers.Add(id, new Dictionary<string, Action>());
            }

            var eventHandlers = handlers[id];

            eventHandlers[eventName] = handler;
        }

        public static Action GetHandler(string id, string eventName)
        {
            if (handlers.ContainsKey(id))
            {
                var eventHandlers = handlers[id];

                if (eventHandlers.ContainsKey(eventName))
                {
                    return eventHandlers[eventName];
                }
            }

            return null;
        }

        public static void CleanComponentHandlers(string id)
        {
            handlers.Remove(id);
        }

        public static bool TriggerEvent(string id, string eventName)
        {
            if (handlers.ContainsKey(id))
            {
                var eventHandlers = handlers[id];

                if (eventHandlers.ContainsKey(eventName))
                {
                    if (eventHandlers[eventName] != null)
                    {
                        eventHandlers[eventName].Invoke();
                    }
                }
            }

            return true;
        }

        public static int GetHandlersCount()
        {
            return handlers.Keys.Count;
        }
    }
}
