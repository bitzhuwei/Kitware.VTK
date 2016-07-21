using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoView : vtkRenderView
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoView";

		public new static readonly string MRClassNameKey;

		static vtkGeoView()
		{
			vtkGeoView.MRClassNameKey = "class vtkGeoView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoView"));
		}

		public vtkGeoView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoView New()
		{
			vtkGeoView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoView.vtkGeoView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoView.vtkGeoView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoView_AddDefaultImageRepresentation_01(HandleRef pThis, HandleRef image, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoAlignedImageRepresentation AddDefaultImageRepresentation(vtkImageData image)
		{
			vtkGeoAlignedImageRepresentation vtkGeoAlignedImageRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoView.vtkGeoView_AddDefaultImageRepresentation_01(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoAlignedImageRepresentation = (vtkGeoAlignedImageRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoAlignedImageRepresentation.Register(null);
				}
			}
			return vtkGeoAlignedImageRepresentation;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_BuildLowResEarth_02(HandleRef pThis, IntPtr origin);

		public void BuildLowResEarth(IntPtr origin)
		{
			vtkGeoView.vtkGeoView_BuildLowResEarth_02(base.GetCppThis(), origin);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoView_GetGeoInteractorStyle_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoInteractorStyle GetGeoInteractorStyle()
		{
			vtkGeoInteractorStyle vtkGeoInteractorStyle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoView.vtkGeoView_GetGeoInteractorStyle_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoInteractorStyle = (vtkGeoInteractorStyle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoInteractorStyle.Register(null);
				}
			}
			return vtkGeoInteractorStyle;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoView_GetLockHeading_04(HandleRef pThis);

		public virtual bool GetLockHeading()
		{
			return vtkGeoView.vtkGeoView_GetLockHeading_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoView_GetTerrain_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGeoTerrain GetTerrain()
		{
			vtkGeoTerrain vtkGeoTerrain = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoView.vtkGeoView_GetTerrain_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTerrain = (vtkGeoTerrain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTerrain.Register(null);
				}
			}
			return vtkGeoTerrain;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoView_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoView.vtkGeoView_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoView_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoView.vtkGeoView_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_LockHeadingOff_08(HandleRef pThis);

		public virtual void LockHeadingOff()
		{
			vtkGeoView.vtkGeoView_LockHeadingOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_LockHeadingOn_09(HandleRef pThis);

		public virtual void LockHeadingOn()
		{
			vtkGeoView.vtkGeoView_LockHeadingOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoView_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoView NewInstance()
		{
			vtkGeoView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoView.vtkGeoView_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_PrepareForRendering_12(HandleRef pThis);

		public virtual void PrepareForRendering()
		{
			vtkGeoView.vtkGeoView_PrepareForRendering_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_Render_13(HandleRef pThis);

		public override void Render()
		{
			vtkGeoView.vtkGeoView_Render_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoView_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoView SafeDownCast(vtkObjectBase o)
		{
			vtkGeoView vtkGeoView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoView.vtkGeoView_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoView = (vtkGeoView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoView.Register(null);
				}
			}
			return vtkGeoView;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_SetGeoInteractorStyle_15(HandleRef pThis, HandleRef style);

		public virtual void SetGeoInteractorStyle(vtkGeoInteractorStyle style)
		{
			vtkGeoView.vtkGeoView_SetGeoInteractorStyle_15(base.GetCppThis(), (style == null) ? default(HandleRef) : style.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_SetLockHeading_16(HandleRef pThis, byte arg0);

		public virtual void SetLockHeading(bool arg0)
		{
			vtkGeoView.vtkGeoView_SetLockHeading_16(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoView_SetTerrain_17(HandleRef pThis, HandleRef terrain);

		public virtual void SetTerrain(vtkGeoTerrain terrain)
		{
			vtkGeoView.vtkGeoView_SetTerrain_17(base.GetCppThis(), (terrain == null) ? default(HandleRef) : terrain.GetCppThis());
		}
	}
}
