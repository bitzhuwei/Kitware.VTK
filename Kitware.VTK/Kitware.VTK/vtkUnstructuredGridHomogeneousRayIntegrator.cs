using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridHomogeneousRayIntegrator : vtkUnstructuredGridVolumeRayIntegrator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridHomogeneousRayIntegrator";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridHomogeneousRayIntegrator()
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.MRClassNameKey = "class vtkUnstructuredGridHomogeneousRayIntegrator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridHomogeneousRayIntegrator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridHomogeneousRayIntegrator"));
		}

		public vtkUnstructuredGridHomogeneousRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridHomogeneousRayIntegrator New()
		{
			vtkUnstructuredGridHomogeneousRayIntegrator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridHomogeneousRayIntegrator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_GetTransferFunctionTableSize_01(HandleRef pThis);

		public virtual int GetTransferFunctionTableSize()
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_GetTransferFunctionTableSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_Initialize_02(HandleRef pThis, HandleRef volume, HandleRef scalars);

		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_Initialize_02(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_Integrate_03(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_Integrate_03(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridHomogeneousRayIntegrator NewInstance()
		{
			vtkUnstructuredGridHomogeneousRayIntegrator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridHomogeneousRayIntegrator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator vtkUnstructuredGridHomogeneousRayIntegrator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridHomogeneousRayIntegrator = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridHomogeneousRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridHomogeneousRayIntegrator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_SetTransferFunctionTableSize_09(HandleRef pThis, int _arg);

		public virtual void SetTransferFunctionTableSize(int _arg)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_SetTransferFunctionTableSize_09(base.GetCppThis(), _arg);
		}
	}
}
