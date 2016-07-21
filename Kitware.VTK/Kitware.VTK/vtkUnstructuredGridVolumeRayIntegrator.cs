using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkUnstructuredGridVolumeRayIntegrator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayIntegrator";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridVolumeRayIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator.MRClassNameKey = "class vtkUnstructuredGridVolumeRayIntegrator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayIntegrator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayIntegrator"));
		}

		public vtkUnstructuredGridVolumeRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayIntegrator_Initialize_01(HandleRef pThis, HandleRef volume, HandleRef scalars);

		public virtual void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_Initialize_01(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayIntegrator_Integrate_02(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		public virtual void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_Integrate_02(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayIntegrator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayIntegrator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayIntegrator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridVolumeRayIntegrator NewInstance()
		{
			vtkUnstructuredGridVolumeRayIntegrator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayIntegrator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeRayIntegrator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayIntegrator = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayIntegrator;
		}
	}
}
