using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridAlgorithm()
		{
			vtkUnstructuredGridAlgorithm.MRClassNameKey = "class vtkUnstructuredGridAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridAlgorithm"));
		}

		public vtkUnstructuredGridAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridAlgorithm New()
		{
			vtkUnstructuredGridAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridAlgorithm_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataObject arg0)
		{
			vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridAlgorithm_AddInput_02(HandleRef pThis, int arg0, HandleRef arg1);

		public void AddInput(int arg0, vtkDataObject arg1)
		{
			vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_AddInput_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_GetOutput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_GetOutput_06(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetOutput(int arg0)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_GetOutput_06(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_GetUnstructuredGridInput_07(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetUnstructuredGridInput(int port)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_GetUnstructuredGridInput_07(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridAlgorithm_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridAlgorithm_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridAlgorithm NewInstance()
		{
			vtkUnstructuredGridAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridAlgorithm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridAlgorithm vtkUnstructuredGridAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridAlgorithm = (vtkUnstructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridAlgorithm.Register(null);
				}
			}
			return vtkUnstructuredGridAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridAlgorithm_SetInput_13(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_SetInput_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridAlgorithm_SetInput_14(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_SetInput_14(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridAlgorithm_SetOutput_15(HandleRef pThis, HandleRef d);

		public virtual void SetOutput(vtkDataObject d)
		{
			vtkUnstructuredGridAlgorithm.vtkUnstructuredGridAlgorithm_SetOutput_15(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}
	}
}
