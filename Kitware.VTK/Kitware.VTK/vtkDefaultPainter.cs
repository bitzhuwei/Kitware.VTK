using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDefaultPainter : vtkPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDefaultPainter";

		public new static readonly string MRClassNameKey;

		static vtkDefaultPainter()
		{
			vtkDefaultPainter.MRClassNameKey = "class vtkDefaultPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDefaultPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDefaultPainter"));
		}

		public vtkDefaultPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDefaultPainter New()
		{
			vtkDefaultPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDefaultPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDefaultPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDefaultPainter.vtkDefaultPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetClipPlanesPainter_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkClipPlanesPainter GetClipPlanesPainter()
		{
			vtkClipPlanesPainter vtkClipPlanesPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetClipPlanesPainter_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipPlanesPainter = (vtkClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipPlanesPainter.Register(null);
				}
			}
			return vtkClipPlanesPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetCoincidentTopologyResolutionPainter_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoincidentTopologyResolutionPainter GetCoincidentTopologyResolutionPainter()
		{
			vtkCoincidentTopologyResolutionPainter vtkCoincidentTopologyResolutionPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetCoincidentTopologyResolutionPainter_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoincidentTopologyResolutionPainter = (vtkCoincidentTopologyResolutionPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoincidentTopologyResolutionPainter.Register(null);
				}
			}
			return vtkCoincidentTopologyResolutionPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetCompositePainter_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCompositePainter GetCompositePainter()
		{
			vtkCompositePainter vtkCompositePainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetCompositePainter_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositePainter = (vtkCompositePainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositePainter.Register(null);
				}
			}
			return vtkCompositePainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetDelegatePainter_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPainter GetDelegatePainter()
		{
			vtkPainter vtkPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetDelegatePainter_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPainter = (vtkPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPainter.Register(null);
				}
			}
			return vtkPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetDisplayListPainter_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDisplayListPainter GetDisplayListPainter()
		{
			vtkDisplayListPainter vtkDisplayListPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetDisplayListPainter_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDisplayListPainter = (vtkDisplayListPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDisplayListPainter.Register(null);
				}
			}
			return vtkDisplayListPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetLightingPainter_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLightingPainter GetLightingPainter()
		{
			vtkLightingPainter vtkLightingPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetLightingPainter_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightingPainter = (vtkLightingPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightingPainter.Register(null);
				}
			}
			return vtkLightingPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetRepresentationPainter_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRepresentationPainter GetRepresentationPainter()
		{
			vtkRepresentationPainter vtkRepresentationPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetRepresentationPainter_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRepresentationPainter = (vtkRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRepresentationPainter.Register(null);
				}
			}
			return vtkRepresentationPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_GetScalarsToColorsPainter_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColorsPainter GetScalarsToColorsPainter()
		{
			vtkScalarsToColorsPainter vtkScalarsToColorsPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_GetScalarsToColorsPainter_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColorsPainter = (vtkScalarsToColorsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColorsPainter.Register(null);
				}
			}
			return vtkScalarsToColorsPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDefaultPainter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDefaultPainter.vtkDefaultPainter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDefaultPainter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDefaultPainter.vtkDefaultPainter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDefaultPainter NewInstance()
		{
			vtkDefaultPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDefaultPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_Render_14(HandleRef pThis, HandleRef renderer, HandleRef actor, uint typeflags, byte forceCompileOnly);

		public override void Render(vtkRenderer renderer, vtkActor actor, uint typeflags, bool forceCompileOnly)
		{
			vtkDefaultPainter.vtkDefaultPainter_Render_14(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis(), typeflags, forceCompileOnly ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPainter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDefaultPainter SafeDownCast(vtkObjectBase o)
		{
			vtkDefaultPainter vtkDefaultPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPainter.vtkDefaultPainter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDefaultPainter = (vtkDefaultPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDefaultPainter.Register(null);
				}
			}
			return vtkDefaultPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetClipPlanesPainter_16(HandleRef pThis, HandleRef arg0);

		public void SetClipPlanesPainter(vtkClipPlanesPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetClipPlanesPainter_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetCoincidentTopologyResolutionPainter_17(HandleRef pThis, HandleRef arg0);

		public void SetCoincidentTopologyResolutionPainter(vtkCoincidentTopologyResolutionPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetCoincidentTopologyResolutionPainter_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetCompositePainter_18(HandleRef pThis, HandleRef arg0);

		public void SetCompositePainter(vtkCompositePainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetCompositePainter_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetDelegatePainter_19(HandleRef pThis, HandleRef arg0);

		public override void SetDelegatePainter(vtkPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetDelegatePainter_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetDisplayListPainter_20(HandleRef pThis, HandleRef arg0);

		public void SetDisplayListPainter(vtkDisplayListPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetDisplayListPainter_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetLightingPainter_21(HandleRef pThis, HandleRef arg0);

		public void SetLightingPainter(vtkLightingPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetLightingPainter_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetRepresentationPainter_22(HandleRef pThis, HandleRef arg0);

		public void SetRepresentationPainter(vtkRepresentationPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetRepresentationPainter_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_SetScalarsToColorsPainter_23(HandleRef pThis, HandleRef arg0);

		public void SetScalarsToColorsPainter(vtkScalarsToColorsPainter arg0)
		{
			vtkDefaultPainter.vtkDefaultPainter_SetScalarsToColorsPainter_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDefaultPainter_UpdateBounds_24(HandleRef pThis, IntPtr bounds);

		public override void UpdateBounds(IntPtr bounds)
		{
			vtkDefaultPainter.vtkDefaultPainter_UpdateBounds_24(base.GetCppThis(), bounds);
		}
	}
}
