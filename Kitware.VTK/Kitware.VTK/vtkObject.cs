using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkObject : vtkObjectBase
	{
		public delegate void vtkObjectEventHandler(vtkObject sender, vtkObjectEventArgs e);

		public new const string MRFullTypeName = "Kitware.VTK.vtkObject";

		public new static readonly string MRClassNameKey;

		private vtkObjectEventRelay AbortCheckEvtRelay;

		private vtkObjectEventRelay AnimationCueTickEvtRelay;

		private vtkObjectEventRelay AnyEvtRelay;

		private vtkObjectEventRelay CharEvtRelay;

		private vtkObjectEventRelay ConfigureEvtRelay;

		private vtkObjectEventRelay ConnectionClosedEvtRelay;

		private vtkObjectEventRelay ConnectionCreatedEvtRelay;

		private vtkObjectEventRelay CreateTimerEvtRelay;

		private vtkObjectEventRelay CursorChangedEvtRelay;

		private vtkObjectEventRelay DeleteEvtRelay;

		private vtkObjectEventRelay DestroyTimerEvtRelay;

		private vtkObjectEventRelay DisableEvtRelay;

		private vtkObjectEventRelay DomainModifiedEvtRelay;

		private vtkObjectEventRelay EnableEvtRelay;

		private vtkObjectEventRelay EndAnimationCueEvtRelay;

		private vtkObjectEventRelay EndEvtRelay;

		private vtkObjectEventRelay EndInteractionEvtRelay;

		private vtkObjectEventRelay EndPickEvtRelay;

		private vtkObjectEventRelay EndWindowLevelEvtRelay;

		private vtkObjectEventRelay EnterEvtRelay;

		private vtkObjectEventRelay ErrorEvtRelay;

		private vtkObjectEventRelay ExecuteInformationEvtRelay;

		private vtkObjectEventRelay ExitEvtRelay;

		private vtkObjectEventRelay ExposeEvtRelay;

		private vtkObjectEventRelay InteractionEvtRelay;

		private vtkObjectEventRelay KeyPressEvtRelay;

		private vtkObjectEventRelay KeyReleaseEvtRelay;

		private vtkObjectEventRelay LeaveEvtRelay;

		private vtkObjectEventRelay LeftButtonPressEvtRelay;

		private vtkObjectEventRelay LeftButtonReleaseEvtRelay;

		private vtkObjectEventRelay MiddleButtonPressEvtRelay;

		private vtkObjectEventRelay MiddleButtonReleaseEvtRelay;

		private vtkObjectEventRelay ModifiedEvtRelay;

		private vtkObjectEventRelay MouseMoveEvtRelay;

		private vtkObjectEventRelay MouseWheelBackwardEvtRelay;

		private vtkObjectEventRelay MouseWheelForwardEvtRelay;

		private vtkObjectEventRelay PickEvtRelay;

		private vtkObjectEventRelay PlacePointEvtRelay;

		private vtkObjectEventRelay PlaceWidgetEvtRelay;

		private vtkObjectEventRelay ProgressEvtRelay;

		private vtkObjectEventRelay PropertyModifiedEvtRelay;

		private vtkObjectEventRelay RegisterEvtRelay;

		private vtkObjectEventRelay RenderEvtRelay;

		private vtkObjectEventRelay RenderWindowMessageEvtRelay;

		private vtkObjectEventRelay ResetCameraClippingRangeEvtRelay;

		private vtkObjectEventRelay ResetCameraEvtRelay;

		private vtkObjectEventRelay ResetWindowLevelEvtRelay;

		private vtkObjectEventRelay RightButtonPressEvtRelay;

		private vtkObjectEventRelay RightButtonReleaseEvtRelay;

		private vtkObjectEventRelay SelectionChangedEvtRelay;

		private vtkObjectEventRelay SetOutputEvtRelay;

		private vtkObjectEventRelay StartAnimationCueEvtRelay;

		private vtkObjectEventRelay StartEvtRelay;

		private vtkObjectEventRelay StartInteractionEvtRelay;

		private vtkObjectEventRelay StartPickEvtRelay;

		private vtkObjectEventRelay StartWindowLevelEvtRelay;

		private vtkObjectEventRelay TimerEvtRelay;

		private vtkObjectEventRelay UnRegisterEvtRelay;

		private vtkObjectEventRelay UpdateEvtRelay;

		private vtkObjectEventRelay UpdateInformationEvtRelay;

		private vtkObjectEventRelay UpdatePropertyEvtRelay;

		private vtkObjectEventRelay VolumeMapperComputeGradientsEndEvtRelay;

		private vtkObjectEventRelay VolumeMapperComputeGradientsProgressEvtRelay;

		private vtkObjectEventRelay VolumeMapperComputeGradientsStartEvtRelay;

		private vtkObjectEventRelay VolumeMapperRenderEndEvtRelay;

		private vtkObjectEventRelay VolumeMapperRenderProgressEvtRelay;

		private vtkObjectEventRelay VolumeMapperRenderStartEvtRelay;

		private vtkObjectEventRelay WarningEvtRelay;

		private vtkObjectEventRelay WidgetActivateEvtRelay;

		private vtkObjectEventRelay WidgetModifiedEvtRelay;

		private vtkObjectEventRelay WidgetValueChangedEvtRelay;

		private vtkObjectEventRelay WindowLevelEvtRelay;

		private vtkObjectEventRelay WrongTagEvtRelay;

		public event vtkObject.vtkObjectEventHandler AbortCheckEvt
		{
			add
			{
				if (null == this.AbortCheckEvtRelay)
				{
					this.AbortCheckEvtRelay = new vtkObjectEventRelay(this, 10u);
				}
				if (null != this.AbortCheckEvtRelay)
				{
					this.AbortCheckEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AbortCheckEvtRelay)
				{
					this.AbortCheckEvtRelay.RemoveHandler(value);
					if (!this.AbortCheckEvtRelay.HasHandlers())
					{
						this.AbortCheckEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler AnimationCueTickEvt
		{
			add
			{
				if (null == this.AnimationCueTickEvtRelay)
				{
					this.AnimationCueTickEvtRelay = new vtkObjectEventRelay(this, 55u);
				}
				if (null != this.AnimationCueTickEvtRelay)
				{
					this.AnimationCueTickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AnimationCueTickEvtRelay)
				{
					this.AnimationCueTickEvtRelay.RemoveHandler(value);
					if (!this.AnimationCueTickEvtRelay.HasHandlers())
					{
						this.AnimationCueTickEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler AnyEvt
		{
			add
			{
				if (null == this.AnyEvtRelay)
				{
					this.AnyEvtRelay = new vtkObjectEventRelay(this, 1u);
				}
				if (null != this.AnyEvtRelay)
				{
					this.AnyEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AnyEvtRelay)
				{
					this.AnyEvtRelay.RemoveHandler(value);
					if (!this.AnyEvtRelay.HasHandlers())
					{
						this.AnyEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler CharEvt
		{
			add
			{
				if (null == this.CharEvtRelay)
				{
					this.CharEvtRelay = new vtkObjectEventRelay(this, 22u);
				}
				if (null != this.CharEvtRelay)
				{
					this.CharEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CharEvtRelay)
				{
					this.CharEvtRelay.RemoveHandler(value);
					if (!this.CharEvtRelay.HasHandlers())
					{
						this.CharEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ConfigureEvt
		{
			add
			{
				if (null == this.ConfigureEvtRelay)
				{
					this.ConfigureEvtRelay = new vtkObjectEventRelay(this, 24u);
				}
				if (null != this.ConfigureEvtRelay)
				{
					this.ConfigureEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ConfigureEvtRelay)
				{
					this.ConfigureEvtRelay.RemoveHandler(value);
					if (!this.ConfigureEvtRelay.HasHandlers())
					{
						this.ConfigureEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ConnectionClosedEvt
		{
			add
			{
				if (null == this.ConnectionClosedEvtRelay)
				{
					this.ConnectionClosedEvtRelay = new vtkObjectEventRelay(this, 67u);
				}
				if (null != this.ConnectionClosedEvtRelay)
				{
					this.ConnectionClosedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ConnectionClosedEvtRelay)
				{
					this.ConnectionClosedEvtRelay.RemoveHandler(value);
					if (!this.ConnectionClosedEvtRelay.HasHandlers())
					{
						this.ConnectionClosedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ConnectionCreatedEvt
		{
			add
			{
				if (null == this.ConnectionCreatedEvtRelay)
				{
					this.ConnectionCreatedEvtRelay = new vtkObjectEventRelay(this, 66u);
				}
				if (null != this.ConnectionCreatedEvtRelay)
				{
					this.ConnectionCreatedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ConnectionCreatedEvtRelay)
				{
					this.ConnectionCreatedEvtRelay.RemoveHandler(value);
					if (!this.ConnectionCreatedEvtRelay.HasHandlers())
					{
						this.ConnectionCreatedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler CreateTimerEvt
		{
			add
			{
				if (null == this.CreateTimerEvtRelay)
				{
					this.CreateTimerEvtRelay = new vtkObjectEventRelay(this, 46u);
				}
				if (null != this.CreateTimerEvtRelay)
				{
					this.CreateTimerEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CreateTimerEvtRelay)
				{
					this.CreateTimerEvtRelay.RemoveHandler(value);
					if (!this.CreateTimerEvtRelay.HasHandlers())
					{
						this.CreateTimerEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler CursorChangedEvt
		{
			add
			{
				if (null == this.CursorChangedEvtRelay)
				{
					this.CursorChangedEvtRelay = new vtkObjectEventRelay(this, 50u);
				}
				if (null != this.CursorChangedEvtRelay)
				{
					this.CursorChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CursorChangedEvtRelay)
				{
					this.CursorChangedEvtRelay.RemoveHandler(value);
					if (!this.CursorChangedEvtRelay.HasHandlers())
					{
						this.CursorChangedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler DeleteEvt
		{
			add
			{
				if (null == this.DeleteEvtRelay)
				{
					this.DeleteEvtRelay = new vtkObjectEventRelay(this, 2u);
				}
				if (null != this.DeleteEvtRelay)
				{
					this.DeleteEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DeleteEvtRelay)
				{
					this.DeleteEvtRelay.RemoveHandler(value);
					if (!this.DeleteEvtRelay.HasHandlers())
					{
						this.DeleteEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler DestroyTimerEvt
		{
			add
			{
				if (null == this.DestroyTimerEvtRelay)
				{
					this.DestroyTimerEvtRelay = new vtkObjectEventRelay(this, 47u);
				}
				if (null != this.DestroyTimerEvtRelay)
				{
					this.DestroyTimerEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DestroyTimerEvtRelay)
				{
					this.DestroyTimerEvtRelay.RemoveHandler(value);
					if (!this.DestroyTimerEvtRelay.HasHandlers())
					{
						this.DestroyTimerEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler DisableEvt
		{
			add
			{
				if (null == this.DisableEvtRelay)
				{
					this.DisableEvtRelay = new vtkObjectEventRelay(this, 45u);
				}
				if (null != this.DisableEvtRelay)
				{
					this.DisableEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DisableEvtRelay)
				{
					this.DisableEvtRelay.RemoveHandler(value);
					if (!this.DisableEvtRelay.HasHandlers())
					{
						this.DisableEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler DomainModifiedEvt
		{
			add
			{
				if (null == this.DomainModifiedEvtRelay)
				{
					this.DomainModifiedEvtRelay = new vtkObjectEventRelay(this, 68u);
				}
				if (null != this.DomainModifiedEvtRelay)
				{
					this.DomainModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DomainModifiedEvtRelay)
				{
					this.DomainModifiedEvtRelay.RemoveHandler(value);
					if (!this.DomainModifiedEvtRelay.HasHandlers())
					{
						this.DomainModifiedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EnableEvt
		{
			add
			{
				if (null == this.EnableEvtRelay)
				{
					this.EnableEvtRelay = new vtkObjectEventRelay(this, 44u);
				}
				if (null != this.EnableEvtRelay)
				{
					this.EnableEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EnableEvtRelay)
				{
					this.EnableEvtRelay.RemoveHandler(value);
					if (!this.EnableEvtRelay.HasHandlers())
					{
						this.EnableEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EndAnimationCueEvt
		{
			add
			{
				if (null == this.EndAnimationCueEvtRelay)
				{
					this.EndAnimationCueEvtRelay = new vtkObjectEventRelay(this, 56u);
				}
				if (null != this.EndAnimationCueEvtRelay)
				{
					this.EndAnimationCueEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndAnimationCueEvtRelay)
				{
					this.EndAnimationCueEvtRelay.RemoveHandler(value);
					if (!this.EndAnimationCueEvtRelay.HasHandlers())
					{
						this.EndAnimationCueEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EndEvt
		{
			add
			{
				if (null == this.EndEvtRelay)
				{
					this.EndEvtRelay = new vtkObjectEventRelay(this, 4u);
				}
				if (null != this.EndEvtRelay)
				{
					this.EndEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndEvtRelay)
				{
					this.EndEvtRelay.RemoveHandler(value);
					if (!this.EndEvtRelay.HasHandlers())
					{
						this.EndEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EndInteractionEvt
		{
			add
			{
				if (null == this.EndInteractionEvtRelay)
				{
					this.EndInteractionEvtRelay = new vtkObjectEventRelay(this, 43u);
				}
				if (null != this.EndInteractionEvtRelay)
				{
					this.EndInteractionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndInteractionEvtRelay)
				{
					this.EndInteractionEvtRelay.RemoveHandler(value);
					if (!this.EndInteractionEvtRelay.HasHandlers())
					{
						this.EndInteractionEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EndPickEvt
		{
			add
			{
				if (null == this.EndPickEvtRelay)
				{
					this.EndPickEvtRelay = new vtkObjectEventRelay(this, 9u);
				}
				if (null != this.EndPickEvtRelay)
				{
					this.EndPickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndPickEvtRelay)
				{
					this.EndPickEvtRelay.RemoveHandler(value);
					if (!this.EndPickEvtRelay.HasHandlers())
					{
						this.EndPickEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EndWindowLevelEvt
		{
			add
			{
				if (null == this.EndWindowLevelEvtRelay)
				{
					this.EndWindowLevelEvtRelay = new vtkObjectEventRelay(this, 36u);
				}
				if (null != this.EndWindowLevelEvtRelay)
				{
					this.EndWindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndWindowLevelEvtRelay)
				{
					this.EndWindowLevelEvtRelay.RemoveHandler(value);
					if (!this.EndWindowLevelEvtRelay.HasHandlers())
					{
						this.EndWindowLevelEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler EnterEvt
		{
			add
			{
				if (null == this.EnterEvtRelay)
				{
					this.EnterEvtRelay = new vtkObjectEventRelay(this, 18u);
				}
				if (null != this.EnterEvtRelay)
				{
					this.EnterEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EnterEvtRelay)
				{
					this.EnterEvtRelay.RemoveHandler(value);
					if (!this.EnterEvtRelay.HasHandlers())
					{
						this.EnterEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ErrorEvt
		{
			add
			{
				if (null == this.ErrorEvtRelay)
				{
					this.ErrorEvtRelay = new vtkObjectEventRelay(this, 39u);
				}
				if (null != this.ErrorEvtRelay)
				{
					this.ErrorEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ErrorEvtRelay)
				{
					this.ErrorEvtRelay.RemoveHandler(value);
					if (!this.ErrorEvtRelay.HasHandlers())
					{
						this.ErrorEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ExecuteInformationEvt
		{
			add
			{
				if (null == this.ExecuteInformationEvtRelay)
				{
					this.ExecuteInformationEvtRelay = new vtkObjectEventRelay(this, 51u);
				}
				if (null != this.ExecuteInformationEvtRelay)
				{
					this.ExecuteInformationEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ExecuteInformationEvtRelay)
				{
					this.ExecuteInformationEvtRelay.RemoveHandler(value);
					if (!this.ExecuteInformationEvtRelay.HasHandlers())
					{
						this.ExecuteInformationEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ExitEvt
		{
			add
			{
				if (null == this.ExitEvtRelay)
				{
					this.ExitEvtRelay = new vtkObjectEventRelay(this, 11u);
				}
				if (null != this.ExitEvtRelay)
				{
					this.ExitEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ExitEvtRelay)
				{
					this.ExitEvtRelay.RemoveHandler(value);
					if (!this.ExitEvtRelay.HasHandlers())
					{
						this.ExitEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ExposeEvt
		{
			add
			{
				if (null == this.ExposeEvtRelay)
				{
					this.ExposeEvtRelay = new vtkObjectEventRelay(this, 23u);
				}
				if (null != this.ExposeEvtRelay)
				{
					this.ExposeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ExposeEvtRelay)
				{
					this.ExposeEvtRelay.RemoveHandler(value);
					if (!this.ExposeEvtRelay.HasHandlers())
					{
						this.ExposeEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler InteractionEvt
		{
			add
			{
				if (null == this.InteractionEvtRelay)
				{
					this.InteractionEvtRelay = new vtkObjectEventRelay(this, 42u);
				}
				if (null != this.InteractionEvtRelay)
				{
					this.InteractionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.InteractionEvtRelay)
				{
					this.InteractionEvtRelay.RemoveHandler(value);
					if (!this.InteractionEvtRelay.HasHandlers())
					{
						this.InteractionEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler KeyPressEvt
		{
			add
			{
				if (null == this.KeyPressEvtRelay)
				{
					this.KeyPressEvtRelay = new vtkObjectEventRelay(this, 20u);
				}
				if (null != this.KeyPressEvtRelay)
				{
					this.KeyPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.KeyPressEvtRelay)
				{
					this.KeyPressEvtRelay.RemoveHandler(value);
					if (!this.KeyPressEvtRelay.HasHandlers())
					{
						this.KeyPressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler KeyReleaseEvt
		{
			add
			{
				if (null == this.KeyReleaseEvtRelay)
				{
					this.KeyReleaseEvtRelay = new vtkObjectEventRelay(this, 21u);
				}
				if (null != this.KeyReleaseEvtRelay)
				{
					this.KeyReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.KeyReleaseEvtRelay)
				{
					this.KeyReleaseEvtRelay.RemoveHandler(value);
					if (!this.KeyReleaseEvtRelay.HasHandlers())
					{
						this.KeyReleaseEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler LeaveEvt
		{
			add
			{
				if (null == this.LeaveEvtRelay)
				{
					this.LeaveEvtRelay = new vtkObjectEventRelay(this, 19u);
				}
				if (null != this.LeaveEvtRelay)
				{
					this.LeaveEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeaveEvtRelay)
				{
					this.LeaveEvtRelay.RemoveHandler(value);
					if (!this.LeaveEvtRelay.HasHandlers())
					{
						this.LeaveEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler LeftButtonPressEvt
		{
			add
			{
				if (null == this.LeftButtonPressEvtRelay)
				{
					this.LeftButtonPressEvtRelay = new vtkObjectEventRelay(this, 12u);
				}
				if (null != this.LeftButtonPressEvtRelay)
				{
					this.LeftButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeftButtonPressEvtRelay)
				{
					this.LeftButtonPressEvtRelay.RemoveHandler(value);
					if (!this.LeftButtonPressEvtRelay.HasHandlers())
					{
						this.LeftButtonPressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler LeftButtonReleaseEvt
		{
			add
			{
				if (null == this.LeftButtonReleaseEvtRelay)
				{
					this.LeftButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 13u);
				}
				if (null != this.LeftButtonReleaseEvtRelay)
				{
					this.LeftButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeftButtonReleaseEvtRelay)
				{
					this.LeftButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.LeftButtonReleaseEvtRelay.HasHandlers())
					{
						this.LeftButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler MiddleButtonPressEvt
		{
			add
			{
				if (null == this.MiddleButtonPressEvtRelay)
				{
					this.MiddleButtonPressEvtRelay = new vtkObjectEventRelay(this, 14u);
				}
				if (null != this.MiddleButtonPressEvtRelay)
				{
					this.MiddleButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MiddleButtonPressEvtRelay)
				{
					this.MiddleButtonPressEvtRelay.RemoveHandler(value);
					if (!this.MiddleButtonPressEvtRelay.HasHandlers())
					{
						this.MiddleButtonPressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler MiddleButtonReleaseEvt
		{
			add
			{
				if (null == this.MiddleButtonReleaseEvtRelay)
				{
					this.MiddleButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 15u);
				}
				if (null != this.MiddleButtonReleaseEvtRelay)
				{
					this.MiddleButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MiddleButtonReleaseEvtRelay)
				{
					this.MiddleButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.MiddleButtonReleaseEvtRelay.HasHandlers())
					{
						this.MiddleButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ModifiedEvt
		{
			add
			{
				if (null == this.ModifiedEvtRelay)
				{
					this.ModifiedEvtRelay = new vtkObjectEventRelay(this, 33u);
				}
				if (null != this.ModifiedEvtRelay)
				{
					this.ModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ModifiedEvtRelay)
				{
					this.ModifiedEvtRelay.RemoveHandler(value);
					if (!this.ModifiedEvtRelay.HasHandlers())
					{
						this.ModifiedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler MouseMoveEvt
		{
			add
			{
				if (null == this.MouseMoveEvtRelay)
				{
					this.MouseMoveEvtRelay = new vtkObjectEventRelay(this, 26u);
				}
				if (null != this.MouseMoveEvtRelay)
				{
					this.MouseMoveEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseMoveEvtRelay)
				{
					this.MouseMoveEvtRelay.RemoveHandler(value);
					if (!this.MouseMoveEvtRelay.HasHandlers())
					{
						this.MouseMoveEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler MouseWheelBackwardEvt
		{
			add
			{
				if (null == this.MouseWheelBackwardEvtRelay)
				{
					this.MouseWheelBackwardEvtRelay = new vtkObjectEventRelay(this, 28u);
				}
				if (null != this.MouseWheelBackwardEvtRelay)
				{
					this.MouseWheelBackwardEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseWheelBackwardEvtRelay)
				{
					this.MouseWheelBackwardEvtRelay.RemoveHandler(value);
					if (!this.MouseWheelBackwardEvtRelay.HasHandlers())
					{
						this.MouseWheelBackwardEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler MouseWheelForwardEvt
		{
			add
			{
				if (null == this.MouseWheelForwardEvtRelay)
				{
					this.MouseWheelForwardEvtRelay = new vtkObjectEventRelay(this, 27u);
				}
				if (null != this.MouseWheelForwardEvtRelay)
				{
					this.MouseWheelForwardEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseWheelForwardEvtRelay)
				{
					this.MouseWheelForwardEvtRelay.RemoveHandler(value);
					if (!this.MouseWheelForwardEvtRelay.HasHandlers())
					{
						this.MouseWheelForwardEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler PickEvt
		{
			add
			{
				if (null == this.PickEvtRelay)
				{
					this.PickEvtRelay = new vtkObjectEventRelay(this, 7u);
				}
				if (null != this.PickEvtRelay)
				{
					this.PickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PickEvtRelay)
				{
					this.PickEvtRelay.RemoveHandler(value);
					if (!this.PickEvtRelay.HasHandlers())
					{
						this.PickEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler PlacePointEvt
		{
			add
			{
				if (null == this.PlacePointEvtRelay)
				{
					this.PlacePointEvtRelay = new vtkObjectEventRelay(this, 48u);
				}
				if (null != this.PlacePointEvtRelay)
				{
					this.PlacePointEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PlacePointEvtRelay)
				{
					this.PlacePointEvtRelay.RemoveHandler(value);
					if (!this.PlacePointEvtRelay.HasHandlers())
					{
						this.PlacePointEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler PlaceWidgetEvt
		{
			add
			{
				if (null == this.PlaceWidgetEvtRelay)
				{
					this.PlaceWidgetEvtRelay = new vtkObjectEventRelay(this, 49u);
				}
				if (null != this.PlaceWidgetEvtRelay)
				{
					this.PlaceWidgetEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PlaceWidgetEvtRelay)
				{
					this.PlaceWidgetEvtRelay.RemoveHandler(value);
					if (!this.PlaceWidgetEvtRelay.HasHandlers())
					{
						this.PlaceWidgetEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ProgressEvt
		{
			add
			{
				if (null == this.ProgressEvtRelay)
				{
					this.ProgressEvtRelay = new vtkObjectEventRelay(this, 6u);
				}
				if (null != this.ProgressEvtRelay)
				{
					this.ProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ProgressEvtRelay)
				{
					this.ProgressEvtRelay.RemoveHandler(value);
					if (!this.ProgressEvtRelay.HasHandlers())
					{
						this.ProgressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler PropertyModifiedEvt
		{
			add
			{
				if (null == this.PropertyModifiedEvtRelay)
				{
					this.PropertyModifiedEvtRelay = new vtkObjectEventRelay(this, 69u);
				}
				if (null != this.PropertyModifiedEvtRelay)
				{
					this.PropertyModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PropertyModifiedEvtRelay)
				{
					this.PropertyModifiedEvtRelay.RemoveHandler(value);
					if (!this.PropertyModifiedEvtRelay.HasHandlers())
					{
						this.PropertyModifiedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler RegisterEvt
		{
			add
			{
				if (null == this.RegisterEvtRelay)
				{
					this.RegisterEvtRelay = new vtkObjectEventRelay(this, 71u);
				}
				if (null != this.RegisterEvtRelay)
				{
					this.RegisterEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RegisterEvtRelay)
				{
					this.RegisterEvtRelay.RemoveHandler(value);
					if (!this.RegisterEvtRelay.HasHandlers())
					{
						this.RegisterEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler RenderEvt
		{
			add
			{
				if (null == this.RenderEvtRelay)
				{
					this.RenderEvtRelay = new vtkObjectEventRelay(this, 5u);
				}
				if (null != this.RenderEvtRelay)
				{
					this.RenderEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RenderEvtRelay)
				{
					this.RenderEvtRelay.RemoveHandler(value);
					if (!this.RenderEvtRelay.HasHandlers())
					{
						this.RenderEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler RenderWindowMessageEvt
		{
			add
			{
				if (null == this.RenderWindowMessageEvtRelay)
				{
					this.RenderWindowMessageEvtRelay = new vtkObjectEventRelay(this, 52u);
				}
				if (null != this.RenderWindowMessageEvtRelay)
				{
					this.RenderWindowMessageEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RenderWindowMessageEvtRelay)
				{
					this.RenderWindowMessageEvtRelay.RemoveHandler(value);
					if (!this.RenderWindowMessageEvtRelay.HasHandlers())
					{
						this.RenderWindowMessageEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ResetCameraClippingRangeEvt
		{
			add
			{
				if (null == this.ResetCameraClippingRangeEvtRelay)
				{
					this.ResetCameraClippingRangeEvtRelay = new vtkObjectEventRelay(this, 32u);
				}
				if (null != this.ResetCameraClippingRangeEvtRelay)
				{
					this.ResetCameraClippingRangeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResetCameraClippingRangeEvtRelay)
				{
					this.ResetCameraClippingRangeEvtRelay.RemoveHandler(value);
					if (!this.ResetCameraClippingRangeEvtRelay.HasHandlers())
					{
						this.ResetCameraClippingRangeEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ResetCameraEvt
		{
			add
			{
				if (null == this.ResetCameraEvtRelay)
				{
					this.ResetCameraEvtRelay = new vtkObjectEventRelay(this, 31u);
				}
				if (null != this.ResetCameraEvtRelay)
				{
					this.ResetCameraEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResetCameraEvtRelay)
				{
					this.ResetCameraEvtRelay.RemoveHandler(value);
					if (!this.ResetCameraEvtRelay.HasHandlers())
					{
						this.ResetCameraEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler ResetWindowLevelEvt
		{
			add
			{
				if (null == this.ResetWindowLevelEvtRelay)
				{
					this.ResetWindowLevelEvtRelay = new vtkObjectEventRelay(this, 37u);
				}
				if (null != this.ResetWindowLevelEvtRelay)
				{
					this.ResetWindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResetWindowLevelEvtRelay)
				{
					this.ResetWindowLevelEvtRelay.RemoveHandler(value);
					if (!this.ResetWindowLevelEvtRelay.HasHandlers())
					{
						this.ResetWindowLevelEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler RightButtonPressEvt
		{
			add
			{
				if (null == this.RightButtonPressEvtRelay)
				{
					this.RightButtonPressEvtRelay = new vtkObjectEventRelay(this, 16u);
				}
				if (null != this.RightButtonPressEvtRelay)
				{
					this.RightButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RightButtonPressEvtRelay)
				{
					this.RightButtonPressEvtRelay.RemoveHandler(value);
					if (!this.RightButtonPressEvtRelay.HasHandlers())
					{
						this.RightButtonPressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler RightButtonReleaseEvt
		{
			add
			{
				if (null == this.RightButtonReleaseEvtRelay)
				{
					this.RightButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 17u);
				}
				if (null != this.RightButtonReleaseEvtRelay)
				{
					this.RightButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RightButtonReleaseEvtRelay)
				{
					this.RightButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.RightButtonReleaseEvtRelay.HasHandlers())
					{
						this.RightButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler SelectionChangedEvt
		{
			add
			{
				if (null == this.SelectionChangedEvtRelay)
				{
					this.SelectionChangedEvtRelay = new vtkObjectEventRelay(this, 75u);
				}
				if (null != this.SelectionChangedEvtRelay)
				{
					this.SelectionChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.SelectionChangedEvtRelay)
				{
					this.SelectionChangedEvtRelay.RemoveHandler(value);
					if (!this.SelectionChangedEvtRelay.HasHandlers())
					{
						this.SelectionChangedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler SetOutputEvt
		{
			add
			{
				if (null == this.SetOutputEvtRelay)
				{
					this.SetOutputEvtRelay = new vtkObjectEventRelay(this, 38u);
				}
				if (null != this.SetOutputEvtRelay)
				{
					this.SetOutputEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.SetOutputEvtRelay)
				{
					this.SetOutputEvtRelay.RemoveHandler(value);
					if (!this.SetOutputEvtRelay.HasHandlers())
					{
						this.SetOutputEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler StartAnimationCueEvt
		{
			add
			{
				if (null == this.StartAnimationCueEvtRelay)
				{
					this.StartAnimationCueEvtRelay = new vtkObjectEventRelay(this, 54u);
				}
				if (null != this.StartAnimationCueEvtRelay)
				{
					this.StartAnimationCueEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartAnimationCueEvtRelay)
				{
					this.StartAnimationCueEvtRelay.RemoveHandler(value);
					if (!this.StartAnimationCueEvtRelay.HasHandlers())
					{
						this.StartAnimationCueEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler StartEvt
		{
			add
			{
				if (null == this.StartEvtRelay)
				{
					this.StartEvtRelay = new vtkObjectEventRelay(this, 3u);
				}
				if (null != this.StartEvtRelay)
				{
					this.StartEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartEvtRelay)
				{
					this.StartEvtRelay.RemoveHandler(value);
					if (!this.StartEvtRelay.HasHandlers())
					{
						this.StartEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler StartInteractionEvt
		{
			add
			{
				if (null == this.StartInteractionEvtRelay)
				{
					this.StartInteractionEvtRelay = new vtkObjectEventRelay(this, 41u);
				}
				if (null != this.StartInteractionEvtRelay)
				{
					this.StartInteractionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartInteractionEvtRelay)
				{
					this.StartInteractionEvtRelay.RemoveHandler(value);
					if (!this.StartInteractionEvtRelay.HasHandlers())
					{
						this.StartInteractionEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler StartPickEvt
		{
			add
			{
				if (null == this.StartPickEvtRelay)
				{
					this.StartPickEvtRelay = new vtkObjectEventRelay(this, 8u);
				}
				if (null != this.StartPickEvtRelay)
				{
					this.StartPickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartPickEvtRelay)
				{
					this.StartPickEvtRelay.RemoveHandler(value);
					if (!this.StartPickEvtRelay.HasHandlers())
					{
						this.StartPickEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler StartWindowLevelEvt
		{
			add
			{
				if (null == this.StartWindowLevelEvtRelay)
				{
					this.StartWindowLevelEvtRelay = new vtkObjectEventRelay(this, 35u);
				}
				if (null != this.StartWindowLevelEvtRelay)
				{
					this.StartWindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartWindowLevelEvtRelay)
				{
					this.StartWindowLevelEvtRelay.RemoveHandler(value);
					if (!this.StartWindowLevelEvtRelay.HasHandlers())
					{
						this.StartWindowLevelEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler TimerEvt
		{
			add
			{
				if (null == this.TimerEvtRelay)
				{
					this.TimerEvtRelay = new vtkObjectEventRelay(this, 25u);
				}
				if (null != this.TimerEvtRelay)
				{
					this.TimerEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TimerEvtRelay)
				{
					this.TimerEvtRelay.RemoveHandler(value);
					if (!this.TimerEvtRelay.HasHandlers())
					{
						this.TimerEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler UnRegisterEvt
		{
			add
			{
				if (null == this.UnRegisterEvtRelay)
				{
					this.UnRegisterEvtRelay = new vtkObjectEventRelay(this, 72u);
				}
				if (null != this.UnRegisterEvtRelay)
				{
					this.UnRegisterEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UnRegisterEvtRelay)
				{
					this.UnRegisterEvtRelay.RemoveHandler(value);
					if (!this.UnRegisterEvtRelay.HasHandlers())
					{
						this.UnRegisterEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler UpdateEvt
		{
			add
			{
				if (null == this.UpdateEvtRelay)
				{
					this.UpdateEvtRelay = new vtkObjectEventRelay(this, 70u);
				}
				if (null != this.UpdateEvtRelay)
				{
					this.UpdateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateEvtRelay)
				{
					this.UpdateEvtRelay.RemoveHandler(value);
					if (!this.UpdateEvtRelay.HasHandlers())
					{
						this.UpdateEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler UpdateInformationEvt
		{
			add
			{
				if (null == this.UpdateInformationEvtRelay)
				{
					this.UpdateInformationEvtRelay = new vtkObjectEventRelay(this, 73u);
				}
				if (null != this.UpdateInformationEvtRelay)
				{
					this.UpdateInformationEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateInformationEvtRelay)
				{
					this.UpdateInformationEvtRelay.RemoveHandler(value);
					if (!this.UpdateInformationEvtRelay.HasHandlers())
					{
						this.UpdateInformationEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler UpdatePropertyEvt
		{
			add
			{
				if (null == this.UpdatePropertyEvtRelay)
				{
					this.UpdatePropertyEvtRelay = new vtkObjectEventRelay(this, 76u);
				}
				if (null != this.UpdatePropertyEvtRelay)
				{
					this.UpdatePropertyEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdatePropertyEvtRelay)
				{
					this.UpdatePropertyEvtRelay.RemoveHandler(value);
					if (!this.UpdatePropertyEvtRelay.HasHandlers())
					{
						this.UpdatePropertyEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler VolumeMapperComputeGradientsEndEvt
		{
			add
			{
				if (null == this.VolumeMapperComputeGradientsEndEvtRelay)
				{
					this.VolumeMapperComputeGradientsEndEvtRelay = new vtkObjectEventRelay(this, 60u);
				}
				if (null != this.VolumeMapperComputeGradientsEndEvtRelay)
				{
					this.VolumeMapperComputeGradientsEndEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperComputeGradientsEndEvtRelay)
				{
					this.VolumeMapperComputeGradientsEndEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperComputeGradientsEndEvtRelay.HasHandlers())
					{
						this.VolumeMapperComputeGradientsEndEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler VolumeMapperComputeGradientsProgressEvt
		{
			add
			{
				if (null == this.VolumeMapperComputeGradientsProgressEvtRelay)
				{
					this.VolumeMapperComputeGradientsProgressEvtRelay = new vtkObjectEventRelay(this, 61u);
				}
				if (null != this.VolumeMapperComputeGradientsProgressEvtRelay)
				{
					this.VolumeMapperComputeGradientsProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperComputeGradientsProgressEvtRelay)
				{
					this.VolumeMapperComputeGradientsProgressEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperComputeGradientsProgressEvtRelay.HasHandlers())
					{
						this.VolumeMapperComputeGradientsProgressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler VolumeMapperComputeGradientsStartEvt
		{
			add
			{
				if (null == this.VolumeMapperComputeGradientsStartEvtRelay)
				{
					this.VolumeMapperComputeGradientsStartEvtRelay = new vtkObjectEventRelay(this, 62u);
				}
				if (null != this.VolumeMapperComputeGradientsStartEvtRelay)
				{
					this.VolumeMapperComputeGradientsStartEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperComputeGradientsStartEvtRelay)
				{
					this.VolumeMapperComputeGradientsStartEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperComputeGradientsStartEvtRelay.HasHandlers())
					{
						this.VolumeMapperComputeGradientsStartEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler VolumeMapperRenderEndEvt
		{
			add
			{
				if (null == this.VolumeMapperRenderEndEvtRelay)
				{
					this.VolumeMapperRenderEndEvtRelay = new vtkObjectEventRelay(this, 57u);
				}
				if (null != this.VolumeMapperRenderEndEvtRelay)
				{
					this.VolumeMapperRenderEndEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperRenderEndEvtRelay)
				{
					this.VolumeMapperRenderEndEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperRenderEndEvtRelay.HasHandlers())
					{
						this.VolumeMapperRenderEndEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler VolumeMapperRenderProgressEvt
		{
			add
			{
				if (null == this.VolumeMapperRenderProgressEvtRelay)
				{
					this.VolumeMapperRenderProgressEvtRelay = new vtkObjectEventRelay(this, 58u);
				}
				if (null != this.VolumeMapperRenderProgressEvtRelay)
				{
					this.VolumeMapperRenderProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperRenderProgressEvtRelay)
				{
					this.VolumeMapperRenderProgressEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperRenderProgressEvtRelay.HasHandlers())
					{
						this.VolumeMapperRenderProgressEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler VolumeMapperRenderStartEvt
		{
			add
			{
				if (null == this.VolumeMapperRenderStartEvtRelay)
				{
					this.VolumeMapperRenderStartEvtRelay = new vtkObjectEventRelay(this, 59u);
				}
				if (null != this.VolumeMapperRenderStartEvtRelay)
				{
					this.VolumeMapperRenderStartEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperRenderStartEvtRelay)
				{
					this.VolumeMapperRenderStartEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperRenderStartEvtRelay.HasHandlers())
					{
						this.VolumeMapperRenderStartEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler WarningEvt
		{
			add
			{
				if (null == this.WarningEvtRelay)
				{
					this.WarningEvtRelay = new vtkObjectEventRelay(this, 40u);
				}
				if (null != this.WarningEvtRelay)
				{
					this.WarningEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WarningEvtRelay)
				{
					this.WarningEvtRelay.RemoveHandler(value);
					if (!this.WarningEvtRelay.HasHandlers())
					{
						this.WarningEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler WidgetActivateEvt
		{
			add
			{
				if (null == this.WidgetActivateEvtRelay)
				{
					this.WidgetActivateEvtRelay = new vtkObjectEventRelay(this, 65u);
				}
				if (null != this.WidgetActivateEvtRelay)
				{
					this.WidgetActivateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WidgetActivateEvtRelay)
				{
					this.WidgetActivateEvtRelay.RemoveHandler(value);
					if (!this.WidgetActivateEvtRelay.HasHandlers())
					{
						this.WidgetActivateEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler WidgetModifiedEvt
		{
			add
			{
				if (null == this.WidgetModifiedEvtRelay)
				{
					this.WidgetModifiedEvtRelay = new vtkObjectEventRelay(this, 63u);
				}
				if (null != this.WidgetModifiedEvtRelay)
				{
					this.WidgetModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WidgetModifiedEvtRelay)
				{
					this.WidgetModifiedEvtRelay.RemoveHandler(value);
					if (!this.WidgetModifiedEvtRelay.HasHandlers())
					{
						this.WidgetModifiedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler WidgetValueChangedEvt
		{
			add
			{
				if (null == this.WidgetValueChangedEvtRelay)
				{
					this.WidgetValueChangedEvtRelay = new vtkObjectEventRelay(this, 64u);
				}
				if (null != this.WidgetValueChangedEvtRelay)
				{
					this.WidgetValueChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WidgetValueChangedEvtRelay)
				{
					this.WidgetValueChangedEvtRelay.RemoveHandler(value);
					if (!this.WidgetValueChangedEvtRelay.HasHandlers())
					{
						this.WidgetValueChangedEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler WindowLevelEvt
		{
			add
			{
				if (null == this.WindowLevelEvtRelay)
				{
					this.WindowLevelEvtRelay = new vtkObjectEventRelay(this, 34u);
				}
				if (null != this.WindowLevelEvtRelay)
				{
					this.WindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowLevelEvtRelay)
				{
					this.WindowLevelEvtRelay.RemoveHandler(value);
					if (!this.WindowLevelEvtRelay.HasHandlers())
					{
						this.WindowLevelEvtRelay = null;
					}
				}
			}
		}

		public event vtkObject.vtkObjectEventHandler WrongTagEvt
		{
			add
			{
				if (null == this.WrongTagEvtRelay)
				{
					this.WrongTagEvtRelay = new vtkObjectEventRelay(this, 53u);
				}
				if (null != this.WrongTagEvtRelay)
				{
					this.WrongTagEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WrongTagEvtRelay)
				{
					this.WrongTagEvtRelay.RemoveHandler(value);
					if (!this.WrongTagEvtRelay.HasHandlers())
					{
						this.WrongTagEvtRelay = null;
					}
				}
			}
		}

		static vtkObject()
		{
			vtkObject.MRClassNameKey = "class vtkObject";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObject"));
		}

		public vtkObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkObject New()
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObject.vtkObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkObject.vtkObject_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkObject_AddObserver_01(HandleRef pThis, uint arg0, HandleRef arg1, float priority);

		public uint AddObserver(uint arg0, vtkCommand arg1, float priority)
		{
			return vtkObject.vtkObject_AddObserver_01(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), priority);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkObject_AddObserver_02(HandleRef pThis, string arg0, HandleRef arg1, float priority);

		public uint AddObserver(string arg0, vtkCommand arg1, float priority)
		{
			return vtkObject.vtkObject_AddObserver_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), priority);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_BreakOnError_03();

		public static void BreakOnError()
		{
			vtkObject.vtkObject_BreakOnError_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_DebugOff_04(HandleRef pThis);

		public virtual void DebugOff()
		{
			vtkObject.vtkObject_DebugOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_DebugOn_05(HandleRef pThis);

		public virtual void DebugOn()
		{
			vtkObject.vtkObject_DebugOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObject_GetCommand_06(HandleRef pThis, uint tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCommand GetCommand(uint tag)
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObject.vtkObject_GetCommand_06(base.GetCppThis(), tag, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkObject_GetDebug_07(HandleRef pThis);

		public byte GetDebug()
		{
			return vtkObject.vtkObject_GetDebug_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_GetGlobalWarningDisplay_08();

		public static int GetGlobalWarningDisplay()
		{
			return vtkObject.vtkObject_GetGlobalWarningDisplay_08();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkObject_GetMTime_09(HandleRef pThis);

		public virtual uint GetMTime()
		{
			return vtkObject.vtkObject_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_GlobalWarningDisplayOff_10();

		public static void GlobalWarningDisplayOff()
		{
			vtkObject.vtkObject_GlobalWarningDisplayOff_10();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_GlobalWarningDisplayOn_11();

		public static void GlobalWarningDisplayOn()
		{
			vtkObject.vtkObject_GlobalWarningDisplayOn_11();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_HasObserver_12(HandleRef pThis, uint arg0, HandleRef arg1);

		public int HasObserver(uint arg0, vtkCommand arg1)
		{
			return vtkObject.vtkObject_HasObserver_12(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_HasObserver_13(HandleRef pThis, string arg0, HandleRef arg1);

		public int HasObserver(string arg0, vtkCommand arg1)
		{
			return vtkObject.vtkObject_HasObserver_13(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_HasObserver_14(HandleRef pThis, uint arg0);

		public int HasObserver(uint arg0)
		{
			return vtkObject.vtkObject_HasObserver_14(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_HasObserver_15(HandleRef pThis, string arg0);

		public int HasObserver(string arg0)
		{
			return vtkObject.vtkObject_HasObserver_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_InvokeEvent_16(HandleRef pThis, uint arg0, IntPtr callData);

		public int InvokeEvent(uint arg0, IntPtr callData)
		{
			return vtkObject.vtkObject_InvokeEvent_16(base.GetCppThis(), arg0, callData);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_InvokeEvent_17(HandleRef pThis, string arg0, IntPtr callData);

		public int InvokeEvent(string arg0, IntPtr callData)
		{
			return vtkObject.vtkObject_InvokeEvent_17(base.GetCppThis(), arg0, callData);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_InvokeEvent_18(HandleRef pThis, uint arg0);

		public int InvokeEvent(uint arg0)
		{
			return vtkObject.vtkObject_InvokeEvent_18(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_InvokeEvent_19(HandleRef pThis, string arg0);

		public int InvokeEvent(string arg0)
		{
			return vtkObject.vtkObject_InvokeEvent_19(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkObject.vtkObject_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkObject_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkObject.vtkObject_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_Modified_22(HandleRef pThis);

		public virtual void Modified()
		{
			vtkObject.vtkObject_Modified_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObject_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObject NewInstance()
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObject.vtkObject_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveAllObservers_25(HandleRef pThis);

		public void RemoveAllObservers()
		{
			vtkObject.vtkObject_RemoveAllObservers_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveObserver_26(HandleRef pThis, HandleRef arg0);

		public void RemoveObserver(vtkCommand arg0)
		{
			vtkObject.vtkObject_RemoveObserver_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveObserver_27(HandleRef pThis, uint tag);

		public void RemoveObserver(uint tag)
		{
			vtkObject.vtkObject_RemoveObserver_27(base.GetCppThis(), tag);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveObservers_28(HandleRef pThis, uint arg0, HandleRef arg1);

		public void RemoveObservers(uint arg0, vtkCommand arg1)
		{
			vtkObject.vtkObject_RemoveObservers_28(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveObservers_29(HandleRef pThis, string arg0, HandleRef arg1);

		public void RemoveObservers(string arg0, vtkCommand arg1)
		{
			vtkObject.vtkObject_RemoveObservers_29(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveObservers_30(HandleRef pThis, uint arg0);

		public void RemoveObservers(uint arg0)
		{
			vtkObject.vtkObject_RemoveObservers_30(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_RemoveObservers_31(HandleRef pThis, string arg0);

		public void RemoveObservers(string arg0)
		{
			vtkObject.vtkObject_RemoveObservers_31(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkObject_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObject SafeDownCast(vtkObjectBase o)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkObject.vtkObject_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_SetDebug_33(HandleRef pThis, byte debugFlag);

		public void SetDebug(byte debugFlag)
		{
			vtkObject.vtkObject_SetDebug_33(base.GetCppThis(), debugFlag);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkObject_SetGlobalWarningDisplay_34(int val);

		public static void SetGlobalWarningDisplay(int val)
		{
			vtkObject.vtkObject_SetGlobalWarningDisplay_34(val);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		private static extern string vtkObject_Print(HandleRef pThis);

		public override string ToString()
		{
			return vtkObject.vtkObject_Print(base.GetCppThis());
		}

		public void RemoveAllHandlersForAllEvents()
		{
			if (null != this.AbortCheckEvtRelay)
			{
				this.AbortCheckEvtRelay.RemoveAllHandlers();
				this.AbortCheckEvtRelay = null;
			}
			if (null != this.AnimationCueTickEvtRelay)
			{
				this.AnimationCueTickEvtRelay.RemoveAllHandlers();
				this.AnimationCueTickEvtRelay = null;
			}
			if (null != this.AnyEvtRelay)
			{
				this.AnyEvtRelay.RemoveAllHandlers();
				this.AnyEvtRelay = null;
			}
			if (null != this.CharEvtRelay)
			{
				this.CharEvtRelay.RemoveAllHandlers();
				this.CharEvtRelay = null;
			}
			if (null != this.ConfigureEvtRelay)
			{
				this.ConfigureEvtRelay.RemoveAllHandlers();
				this.ConfigureEvtRelay = null;
			}
			if (null != this.ConnectionClosedEvtRelay)
			{
				this.ConnectionClosedEvtRelay.RemoveAllHandlers();
				this.ConnectionClosedEvtRelay = null;
			}
			if (null != this.ConnectionCreatedEvtRelay)
			{
				this.ConnectionCreatedEvtRelay.RemoveAllHandlers();
				this.ConnectionCreatedEvtRelay = null;
			}
			if (null != this.CreateTimerEvtRelay)
			{
				this.CreateTimerEvtRelay.RemoveAllHandlers();
				this.CreateTimerEvtRelay = null;
			}
			if (null != this.CursorChangedEvtRelay)
			{
				this.CursorChangedEvtRelay.RemoveAllHandlers();
				this.CursorChangedEvtRelay = null;
			}
			if (null != this.DeleteEvtRelay)
			{
				this.DeleteEvtRelay.RemoveAllHandlers();
				this.DeleteEvtRelay = null;
			}
			if (null != this.DestroyTimerEvtRelay)
			{
				this.DestroyTimerEvtRelay.RemoveAllHandlers();
				this.DestroyTimerEvtRelay = null;
			}
			if (null != this.DisableEvtRelay)
			{
				this.DisableEvtRelay.RemoveAllHandlers();
				this.DisableEvtRelay = null;
			}
			if (null != this.DomainModifiedEvtRelay)
			{
				this.DomainModifiedEvtRelay.RemoveAllHandlers();
				this.DomainModifiedEvtRelay = null;
			}
			if (null != this.EnableEvtRelay)
			{
				this.EnableEvtRelay.RemoveAllHandlers();
				this.EnableEvtRelay = null;
			}
			if (null != this.EndAnimationCueEvtRelay)
			{
				this.EndAnimationCueEvtRelay.RemoveAllHandlers();
				this.EndAnimationCueEvtRelay = null;
			}
			if (null != this.EndEvtRelay)
			{
				this.EndEvtRelay.RemoveAllHandlers();
				this.EndEvtRelay = null;
			}
			if (null != this.EndInteractionEvtRelay)
			{
				this.EndInteractionEvtRelay.RemoveAllHandlers();
				this.EndInteractionEvtRelay = null;
			}
			if (null != this.EndPickEvtRelay)
			{
				this.EndPickEvtRelay.RemoveAllHandlers();
				this.EndPickEvtRelay = null;
			}
			if (null != this.EndWindowLevelEvtRelay)
			{
				this.EndWindowLevelEvtRelay.RemoveAllHandlers();
				this.EndWindowLevelEvtRelay = null;
			}
			if (null != this.EnterEvtRelay)
			{
				this.EnterEvtRelay.RemoveAllHandlers();
				this.EnterEvtRelay = null;
			}
			if (null != this.ErrorEvtRelay)
			{
				this.ErrorEvtRelay.RemoveAllHandlers();
				this.ErrorEvtRelay = null;
			}
			if (null != this.ExecuteInformationEvtRelay)
			{
				this.ExecuteInformationEvtRelay.RemoveAllHandlers();
				this.ExecuteInformationEvtRelay = null;
			}
			if (null != this.ExitEvtRelay)
			{
				this.ExitEvtRelay.RemoveAllHandlers();
				this.ExitEvtRelay = null;
			}
			if (null != this.ExposeEvtRelay)
			{
				this.ExposeEvtRelay.RemoveAllHandlers();
				this.ExposeEvtRelay = null;
			}
			if (null != this.InteractionEvtRelay)
			{
				this.InteractionEvtRelay.RemoveAllHandlers();
				this.InteractionEvtRelay = null;
			}
			if (null != this.KeyPressEvtRelay)
			{
				this.KeyPressEvtRelay.RemoveAllHandlers();
				this.KeyPressEvtRelay = null;
			}
			if (null != this.KeyReleaseEvtRelay)
			{
				this.KeyReleaseEvtRelay.RemoveAllHandlers();
				this.KeyReleaseEvtRelay = null;
			}
			if (null != this.LeaveEvtRelay)
			{
				this.LeaveEvtRelay.RemoveAllHandlers();
				this.LeaveEvtRelay = null;
			}
			if (null != this.LeftButtonPressEvtRelay)
			{
				this.LeftButtonPressEvtRelay.RemoveAllHandlers();
				this.LeftButtonPressEvtRelay = null;
			}
			if (null != this.LeftButtonReleaseEvtRelay)
			{
				this.LeftButtonReleaseEvtRelay.RemoveAllHandlers();
				this.LeftButtonReleaseEvtRelay = null;
			}
			if (null != this.MiddleButtonPressEvtRelay)
			{
				this.MiddleButtonPressEvtRelay.RemoveAllHandlers();
				this.MiddleButtonPressEvtRelay = null;
			}
			if (null != this.MiddleButtonReleaseEvtRelay)
			{
				this.MiddleButtonReleaseEvtRelay.RemoveAllHandlers();
				this.MiddleButtonReleaseEvtRelay = null;
			}
			if (null != this.ModifiedEvtRelay)
			{
				this.ModifiedEvtRelay.RemoveAllHandlers();
				this.ModifiedEvtRelay = null;
			}
			if (null != this.MouseMoveEvtRelay)
			{
				this.MouseMoveEvtRelay.RemoveAllHandlers();
				this.MouseMoveEvtRelay = null;
			}
			if (null != this.MouseWheelBackwardEvtRelay)
			{
				this.MouseWheelBackwardEvtRelay.RemoveAllHandlers();
				this.MouseWheelBackwardEvtRelay = null;
			}
			if (null != this.MouseWheelForwardEvtRelay)
			{
				this.MouseWheelForwardEvtRelay.RemoveAllHandlers();
				this.MouseWheelForwardEvtRelay = null;
			}
			if (null != this.PickEvtRelay)
			{
				this.PickEvtRelay.RemoveAllHandlers();
				this.PickEvtRelay = null;
			}
			if (null != this.PlacePointEvtRelay)
			{
				this.PlacePointEvtRelay.RemoveAllHandlers();
				this.PlacePointEvtRelay = null;
			}
			if (null != this.PlaceWidgetEvtRelay)
			{
				this.PlaceWidgetEvtRelay.RemoveAllHandlers();
				this.PlaceWidgetEvtRelay = null;
			}
			if (null != this.ProgressEvtRelay)
			{
				this.ProgressEvtRelay.RemoveAllHandlers();
				this.ProgressEvtRelay = null;
			}
			if (null != this.PropertyModifiedEvtRelay)
			{
				this.PropertyModifiedEvtRelay.RemoveAllHandlers();
				this.PropertyModifiedEvtRelay = null;
			}
			if (null != this.RegisterEvtRelay)
			{
				this.RegisterEvtRelay.RemoveAllHandlers();
				this.RegisterEvtRelay = null;
			}
			if (null != this.RenderEvtRelay)
			{
				this.RenderEvtRelay.RemoveAllHandlers();
				this.RenderEvtRelay = null;
			}
			if (null != this.RenderWindowMessageEvtRelay)
			{
				this.RenderWindowMessageEvtRelay.RemoveAllHandlers();
				this.RenderWindowMessageEvtRelay = null;
			}
			if (null != this.ResetCameraClippingRangeEvtRelay)
			{
				this.ResetCameraClippingRangeEvtRelay.RemoveAllHandlers();
				this.ResetCameraClippingRangeEvtRelay = null;
			}
			if (null != this.ResetCameraEvtRelay)
			{
				this.ResetCameraEvtRelay.RemoveAllHandlers();
				this.ResetCameraEvtRelay = null;
			}
			if (null != this.ResetWindowLevelEvtRelay)
			{
				this.ResetWindowLevelEvtRelay.RemoveAllHandlers();
				this.ResetWindowLevelEvtRelay = null;
			}
			if (null != this.RightButtonPressEvtRelay)
			{
				this.RightButtonPressEvtRelay.RemoveAllHandlers();
				this.RightButtonPressEvtRelay = null;
			}
			if (null != this.RightButtonReleaseEvtRelay)
			{
				this.RightButtonReleaseEvtRelay.RemoveAllHandlers();
				this.RightButtonReleaseEvtRelay = null;
			}
			if (null != this.SelectionChangedEvtRelay)
			{
				this.SelectionChangedEvtRelay.RemoveAllHandlers();
				this.SelectionChangedEvtRelay = null;
			}
			if (null != this.SetOutputEvtRelay)
			{
				this.SetOutputEvtRelay.RemoveAllHandlers();
				this.SetOutputEvtRelay = null;
			}
			if (null != this.StartAnimationCueEvtRelay)
			{
				this.StartAnimationCueEvtRelay.RemoveAllHandlers();
				this.StartAnimationCueEvtRelay = null;
			}
			if (null != this.StartEvtRelay)
			{
				this.StartEvtRelay.RemoveAllHandlers();
				this.StartEvtRelay = null;
			}
			if (null != this.StartInteractionEvtRelay)
			{
				this.StartInteractionEvtRelay.RemoveAllHandlers();
				this.StartInteractionEvtRelay = null;
			}
			if (null != this.StartPickEvtRelay)
			{
				this.StartPickEvtRelay.RemoveAllHandlers();
				this.StartPickEvtRelay = null;
			}
			if (null != this.StartWindowLevelEvtRelay)
			{
				this.StartWindowLevelEvtRelay.RemoveAllHandlers();
				this.StartWindowLevelEvtRelay = null;
			}
			if (null != this.TimerEvtRelay)
			{
				this.TimerEvtRelay.RemoveAllHandlers();
				this.TimerEvtRelay = null;
			}
			if (null != this.UnRegisterEvtRelay)
			{
				this.UnRegisterEvtRelay.RemoveAllHandlers();
				this.UnRegisterEvtRelay = null;
			}
			if (null != this.UpdateEvtRelay)
			{
				this.UpdateEvtRelay.RemoveAllHandlers();
				this.UpdateEvtRelay = null;
			}
			if (null != this.UpdateInformationEvtRelay)
			{
				this.UpdateInformationEvtRelay.RemoveAllHandlers();
				this.UpdateInformationEvtRelay = null;
			}
			if (null != this.UpdatePropertyEvtRelay)
			{
				this.UpdatePropertyEvtRelay.RemoveAllHandlers();
				this.UpdatePropertyEvtRelay = null;
			}
			if (null != this.VolumeMapperComputeGradientsEndEvtRelay)
			{
				this.VolumeMapperComputeGradientsEndEvtRelay.RemoveAllHandlers();
				this.VolumeMapperComputeGradientsEndEvtRelay = null;
			}
			if (null != this.VolumeMapperComputeGradientsProgressEvtRelay)
			{
				this.VolumeMapperComputeGradientsProgressEvtRelay.RemoveAllHandlers();
				this.VolumeMapperComputeGradientsProgressEvtRelay = null;
			}
			if (null != this.VolumeMapperComputeGradientsStartEvtRelay)
			{
				this.VolumeMapperComputeGradientsStartEvtRelay.RemoveAllHandlers();
				this.VolumeMapperComputeGradientsStartEvtRelay = null;
			}
			if (null != this.VolumeMapperRenderEndEvtRelay)
			{
				this.VolumeMapperRenderEndEvtRelay.RemoveAllHandlers();
				this.VolumeMapperRenderEndEvtRelay = null;
			}
			if (null != this.VolumeMapperRenderProgressEvtRelay)
			{
				this.VolumeMapperRenderProgressEvtRelay.RemoveAllHandlers();
				this.VolumeMapperRenderProgressEvtRelay = null;
			}
			if (null != this.VolumeMapperRenderStartEvtRelay)
			{
				this.VolumeMapperRenderStartEvtRelay.RemoveAllHandlers();
				this.VolumeMapperRenderStartEvtRelay = null;
			}
			if (null != this.WarningEvtRelay)
			{
				this.WarningEvtRelay.RemoveAllHandlers();
				this.WarningEvtRelay = null;
			}
			if (null != this.WidgetActivateEvtRelay)
			{
				this.WidgetActivateEvtRelay.RemoveAllHandlers();
				this.WidgetActivateEvtRelay = null;
			}
			if (null != this.WidgetModifiedEvtRelay)
			{
				this.WidgetModifiedEvtRelay.RemoveAllHandlers();
				this.WidgetModifiedEvtRelay = null;
			}
			if (null != this.WidgetValueChangedEvtRelay)
			{
				this.WidgetValueChangedEvtRelay.RemoveAllHandlers();
				this.WidgetValueChangedEvtRelay = null;
			}
			if (null != this.WindowLevelEvtRelay)
			{
				this.WindowLevelEvtRelay.RemoveAllHandlers();
				this.WindowLevelEvtRelay = null;
			}
			if (null != this.WrongTagEvtRelay)
			{
				this.WrongTagEvtRelay.RemoveAllHandlers();
				this.WrongTagEvtRelay = null;
			}
		}
	}
}
