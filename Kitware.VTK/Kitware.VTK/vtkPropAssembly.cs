using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPropAssembly : vtkProp
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPropAssembly";

		public new static readonly string MRClassNameKey;

		static vtkPropAssembly()
		{
			vtkPropAssembly.MRClassNameKey = "class vtkPropAssembly";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPropAssembly.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropAssembly"));
		}

		public vtkPropAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPropAssembly New()
		{
			vtkPropAssembly result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPropAssembly() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPropAssembly.vtkPropAssembly_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPropAssembly_AddPart_01(HandleRef pThis, HandleRef arg0);

		public void AddPart(vtkProp arg0)
		{
			vtkPropAssembly.vtkPropAssembly_AddPart_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPropAssembly_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

		public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkPropAssembly.vtkPropAssembly_BuildPaths_02(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropAssembly_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkPropAssembly_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkPropAssembly.vtkPropAssembly_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropAssembly_GetNextPath_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_GetNextPath_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_GetNumberOfPaths_06(HandleRef pThis);

		public override int GetNumberOfPaths()
		{
			return vtkPropAssembly.vtkPropAssembly_GetNumberOfPaths_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropAssembly_GetParts_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPropCollection GetParts()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_GetParts_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPropAssembly.vtkPropAssembly_HasTranslucentPolygonalGeometry_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPropAssembly_InitPathTraversal_09(HandleRef pThis);

		public override void InitPathTraversal()
		{
			vtkPropAssembly.vtkPropAssembly_InitPathTraversal_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPropAssembly.vtkPropAssembly_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPropAssembly.vtkPropAssembly_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropAssembly_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPropAssembly NewInstance()
		{
			vtkPropAssembly result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPropAssembly_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPropAssembly.vtkPropAssembly_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPropAssembly_RemovePart_15(HandleRef pThis, HandleRef arg0);

		public void RemovePart(vtkProp arg0)
		{
			vtkPropAssembly.vtkPropAssembly_RemovePart_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef ren);

		public override int RenderOpaqueGeometry(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderOpaqueGeometry_16(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_RenderOverlay_17(HandleRef pThis, HandleRef ren);

		public override int RenderOverlay(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderOverlay_17(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_RenderTranslucentPolygonalGeometry_18(HandleRef pThis, HandleRef ren);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderTranslucentPolygonalGeometry_18(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPropAssembly_RenderVolumetricGeometry_19(HandleRef pThis, HandleRef ren);

		public override int RenderVolumetricGeometry(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderVolumetricGeometry_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropAssembly_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPropAssembly SafeDownCast(vtkObjectBase o)
		{
			vtkPropAssembly vtkPropAssembly = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropAssembly = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropAssembly.Register(null);
				}
			}
			return vtkPropAssembly;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPropAssembly_ShallowCopy_21(HandleRef pThis, HandleRef Prop);

		public override void ShallowCopy(vtkProp Prop)
		{
			vtkPropAssembly.vtkPropAssembly_ShallowCopy_21(base.GetCppThis(), (Prop == null) ? default(HandleRef) : Prop.GetCppThis());
		}
	}
}
