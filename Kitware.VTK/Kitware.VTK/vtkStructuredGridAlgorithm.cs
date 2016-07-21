using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGridAlgorithm : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGridAlgorithm()
		{
			vtkStructuredGridAlgorithm.MRClassNameKey = "class vtkStructuredGridAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridAlgorithm"));
		}

		public vtkStructuredGridAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridAlgorithm New()
		{
			vtkStructuredGridAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredGridAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridAlgorithm_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkDataObject arg0)
		{
			vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridAlgorithm_AddInput_02(HandleRef pThis, int arg0, HandleRef arg1);

		public void AddInput(int arg0, vtkDataObject arg1)
		{
			vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_AddInput_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStructuredGridAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkStructuredGridAlgorithm_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_GetOutput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridAlgorithm_GetOutput_06(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetOutput(int arg0)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_GetOutput_06(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridAlgorithm_GetStructuredGridInput_07(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetStructuredGridInput(int port)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_GetStructuredGridInput_07(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGridAlgorithm_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGridAlgorithm_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridAlgorithm_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGridAlgorithm NewInstance()
		{
			vtkStructuredGridAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridAlgorithm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridAlgorithm vtkStructuredGridAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridAlgorithm = (vtkStructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridAlgorithm.Register(null);
				}
			}
			return vtkStructuredGridAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridAlgorithm_SetInput_13(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_SetInput_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridAlgorithm_SetInput_14(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_SetInput_14(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridAlgorithm_SetOutput_15(HandleRef pThis, HandleRef d);

		public virtual void SetOutput(vtkDataObject d)
		{
			vtkStructuredGridAlgorithm.vtkStructuredGridAlgorithm_SetOutput_15(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}
	}
}
