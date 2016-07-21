using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssembly : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssembly";

		public new static readonly string MRClassNameKey;

		static vtkAssembly()
		{
			vtkAssembly.MRClassNameKey = "class vtkAssembly";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssembly.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssembly"));
		}

		public vtkAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssembly New()
		{
			vtkAssembly result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssembly.vtkAssembly_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssembly() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssembly.vtkAssembly_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_AddPart_01(HandleRef pThis, HandleRef arg0);

		public void AddPart(vtkProp3D arg0)
		{
			vtkAssembly.vtkAssembly_AddPart_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

		public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkAssembly.vtkAssembly_BuildPaths_02(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_GetActors_03(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAssembly.vtkAssembly_GetActors_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_GetBounds_04(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkAssembly.vtkAssembly_GetBounds_04(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAssembly_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAssembly.vtkAssembly_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkAssembly_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAssembly.vtkAssembly_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAssembly_GetNextPath_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssembly.vtkAssembly_GetNextPath_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_GetNumberOfPaths_08(HandleRef pThis);

		public override int GetNumberOfPaths()
		{
			return vtkAssembly.vtkAssembly_GetNumberOfPaths_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAssembly_GetParts_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp3DCollection GetParts()
		{
			vtkProp3DCollection vtkProp3DCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssembly.vtkAssembly_GetParts_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DCollection = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DCollection.Register(null);
				}
			}
			return vtkProp3DCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_GetVolumes_10(HandleRef pThis, HandleRef arg0);

		public override void GetVolumes(vtkPropCollection arg0)
		{
			vtkAssembly.vtkAssembly_GetVolumes_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAssembly.vtkAssembly_HasTranslucentPolygonalGeometry_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_InitPathTraversal_12(HandleRef pThis);

		public override void InitPathTraversal()
		{
			vtkAssembly.vtkAssembly_InitPathTraversal_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssembly.vtkAssembly_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssembly.vtkAssembly_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAssembly_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssembly NewInstance()
		{
			vtkAssembly result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssembly.vtkAssembly_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAssembly.vtkAssembly_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_RemovePart_18(HandleRef pThis, HandleRef arg0);

		public void RemovePart(vtkProp3D arg0)
		{
			vtkAssembly.vtkAssembly_RemovePart_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef ren);

		public override int RenderOpaqueGeometry(vtkViewport ren)
		{
			return vtkAssembly.vtkAssembly_RenderOpaqueGeometry_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef ren);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
		{
			return vtkAssembly.vtkAssembly_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAssembly_RenderVolumetricGeometry_21(HandleRef pThis, HandleRef ren);

		public override int RenderVolumetricGeometry(vtkViewport ren)
		{
			return vtkAssembly.vtkAssembly_RenderVolumetricGeometry_21(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAssembly_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssembly SafeDownCast(vtkObjectBase o)
		{
			vtkAssembly vtkAssembly = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssembly.vtkAssembly_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssembly = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssembly.Register(null);
				}
			}
			return vtkAssembly;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAssembly_ShallowCopy_23(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAssembly.vtkAssembly_ShallowCopy_23(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
