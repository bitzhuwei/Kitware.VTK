using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlaybackRepresentation : vtkBorderRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaybackRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkPlaybackRepresentation()
		{
			vtkPlaybackRepresentation.MRClassNameKey = "class vtkPlaybackRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaybackRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaybackRepresentation"));
		}

		public vtkPlaybackRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaybackRepresentation New()
		{
			vtkPlaybackRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlaybackRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlaybackRepresentation.vtkPlaybackRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_BackwardOneFrame_01(HandleRef pThis);

		public virtual void BackwardOneFrame()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_BackwardOneFrame_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_BuildRepresentation_02(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_BuildRepresentation_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_ForwardOneFrame_03(HandleRef pThis);

		public virtual void ForwardOneFrame()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_ForwardOneFrame_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackRepresentation_GetProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetProperty_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_GetSize_06(HandleRef pThis, IntPtr size);

		public override void GetSize(IntPtr size)
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_GetSize_06(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackRepresentation_HasTranslucentPolygonalGeometry_07(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_HasTranslucentPolygonalGeometry_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackRepresentation_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackRepresentation_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_JumpToBeginning_10(HandleRef pThis);

		public virtual void JumpToBeginning()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_JumpToBeginning_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_JumpToEnd_11(HandleRef pThis);

		public virtual void JumpToEnd()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_JumpToEnd_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlaybackRepresentation NewInstance()
		{
			vtkPlaybackRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_Play_14(HandleRef pThis);

		public virtual void Play()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_Play_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_ReleaseGraphicsResources_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackRepresentation_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_RenderOpaqueGeometry_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackRepresentation_RenderOverlay_17(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_RenderOverlay_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPlaybackRepresentation_RenderTranslucentPolygonalGeometry_18(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkPlaybackRepresentation.vtkPlaybackRepresentation_RenderTranslucentPolygonalGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPlaybackRepresentation_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlaybackRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkPlaybackRepresentation vtkPlaybackRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlaybackRepresentation.vtkPlaybackRepresentation_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaybackRepresentation = (vtkPlaybackRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaybackRepresentation.Register(null);
				}
			}
			return vtkPlaybackRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPlaybackRepresentation_Stop_20(HandleRef pThis);

		public virtual void Stop()
		{
			vtkPlaybackRepresentation.vtkPlaybackRepresentation_Stop_20(base.GetCppThis());
		}
	}
}
