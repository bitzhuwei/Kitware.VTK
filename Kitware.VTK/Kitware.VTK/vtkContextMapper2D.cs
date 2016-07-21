using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContextMapper2D : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextMapper2D";

		public new static readonly string MRClassNameKey;

		static vtkContextMapper2D()
		{
			vtkContextMapper2D.MRClassNameKey = "class vtkContextMapper2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextMapper2D"));
		}

		public vtkContextMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextMapper2D New()
		{
			vtkContextMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContextMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContextMapper2D.vtkContextMapper2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextMapper2D_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextMapper2D_GetInputAbstractArrayToProcess_02(HandleRef pThis, int idx, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetInputAbstractArrayToProcess(int idx, vtkDataObject input)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_GetInputAbstractArrayToProcess_02(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextMapper2D_GetInputArrayToProcess_03(HandleRef pThis, int idx, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetInputArrayToProcess(int idx, vtkDataObject input)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_GetInputArrayToProcess_03(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextMapper2D_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextMapper2D.vtkContextMapper2D_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextMapper2D_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextMapper2D.vtkContextMapper2D_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextMapper2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextMapper2D NewInstance()
		{
			vtkContextMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextMapper2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkContextMapper2D vtkContextMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextMapper2D = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextMapper2D.Register(null);
				}
			}
			return vtkContextMapper2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextMapper2D_SetInput_09(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkTable input)
		{
			vtkContextMapper2D.vtkContextMapper2D_SetInput_09(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
