using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridPreIntegration : vtkUnstructuredGridVolumeRayIntegrator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridPreIntegration";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridPreIntegration()
		{
			vtkUnstructuredGridPreIntegration.MRClassNameKey = "class vtkUnstructuredGridPreIntegration";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridPreIntegration.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridPreIntegration"));
		}

		public vtkUnstructuredGridPreIntegration(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridPreIntegration New()
		{
			vtkUnstructuredGridPreIntegration result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridPreIntegration() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPreIntegration_GetIncrementalPreIntegration_01(HandleRef pThis);

		public virtual int GetIncrementalPreIntegration()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIncrementalPreIntegration_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetIndexedTableEntry_02(HandleRef pThis, int scalar_front_index, int scalar_back_index, int length_index, int component);

		public IntPtr GetIndexedTableEntry(int scalar_front_index, int scalar_back_index, int length_index, int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIndexedTableEntry_02(base.GetCppThis(), scalar_front_index, scalar_back_index, length_index, component);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthResolution_03(HandleRef pThis);

		public virtual int GetIntegrationTableLengthResolution()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthResolution_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthScale_04(HandleRef pThis);

		public virtual double GetIntegrationTableLengthScale()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableLengthScale_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarResolution_05(HandleRef pThis);

		public virtual int GetIntegrationTableScalarResolution()
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarResolution_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarScale_06(HandleRef pThis, int component);

		public virtual double GetIntegrationTableScalarScale(int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarScale_06(base.GetCppThis(), component);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarShift_07(HandleRef pThis, int component);

		public virtual double GetIntegrationTableScalarShift(int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrationTableScalarShift_07(base.GetCppThis(), component);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetIntegrator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnstructuredGridVolumeRayIntegrator GetIntegrator()
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetIntegrator_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetPreIntegrationTable_09(HandleRef pThis, int component);

		public virtual IntPtr GetPreIntegrationTable(int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetPreIntegrationTable_09(base.GetCppThis(), component);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_GetTableEntry_10(HandleRef pThis, double scalar_front, double scalar_back, double length, int component);

		public IntPtr GetTableEntry(double scalar_front, double scalar_back, double length, int component)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_GetTableEntry_10(base.GetCppThis(), scalar_front, scalar_back, length, component);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOff_11(HandleRef pThis);

		public virtual void IncrementalPreIntegrationOff()
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOn_12(HandleRef pThis);

		public virtual void IncrementalPreIntegrationOn()
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IncrementalPreIntegrationOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_Initialize_13(HandleRef pThis, HandleRef volume, HandleRef scalars);

		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_Initialize_13(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_Integrate_14(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_Integrate_14(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPreIntegration_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridPreIntegration_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridPreIntegration NewInstance()
		{
			vtkUnstructuredGridPreIntegration result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridPreIntegration_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridPreIntegration SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridPreIntegration vtkUnstructuredGridPreIntegration = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridPreIntegration = (vtkUnstructuredGridPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridPreIntegration.Register(null);
				}
			}
			return vtkUnstructuredGridPreIntegration;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIncrementalPreIntegration_20(HandleRef pThis, int _arg);

		public virtual void SetIncrementalPreIntegration(int _arg)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIncrementalPreIntegration_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrationTableLengthResolution_21(HandleRef pThis, int _arg);

		public virtual void SetIntegrationTableLengthResolution(int _arg)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIntegrationTableLengthResolution_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrationTableScalarResolution_22(HandleRef pThis, int _arg);

		public virtual void SetIntegrationTableScalarResolution(int _arg)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIntegrationTableScalarResolution_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridPreIntegration_SetIntegrator_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetIntegrator(vtkUnstructuredGridVolumeRayIntegrator arg0)
		{
			vtkUnstructuredGridPreIntegration.vtkUnstructuredGridPreIntegration_SetIntegrator_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
