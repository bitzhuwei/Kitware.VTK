using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiThreshold : vtkMultiBlockDataSetAlgorithm
	{
		public enum Closure
		{
			CLOSED = 1,
			OPEN = 0
		}

		public enum Norm
		{
			L1_NORM = -1,
			L2_NORM = -2,
			LINFINITY_NORM = -3
		}

		public enum SetOperation
		{
			AND,
			NAND = 4,
			OR = 1,
			WOR = 3,
			XOR = 2
		}

		public delegate double TupleNorm(IntPtr arg0, long arg1, int arg2);

		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiThreshold";

		public new static readonly string MRClassNameKey;

		static vtkMultiThreshold()
		{
			vtkMultiThreshold.MRClassNameKey = "class vtkMultiThreshold";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiThreshold"));
		}

		public vtkMultiThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiThreshold New()
		{
			vtkMultiThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiThreshold.vtkMultiThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiThreshold.vtkMultiThreshold_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddBandpassIntervalSet_01(HandleRef pThis, double xmin, double xmax, int assoc, string arrayName, int component, int allScalars);

		public int AddBandpassIntervalSet(double xmin, double xmax, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddBandpassIntervalSet_01(base.GetCppThis(), xmin, xmax, assoc, arrayName, component, allScalars);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddBooleanSet_02(HandleRef pThis, int operation, int numInputs, IntPtr inputs);

		public int AddBooleanSet(int operation, int numInputs, IntPtr inputs)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddBooleanSet_02(base.GetCppThis(), operation, numInputs, inputs);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddHighpassIntervalSet_03(HandleRef pThis, double xmin, int assoc, string arrayName, int component, int allScalars);

		public int AddHighpassIntervalSet(double xmin, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddHighpassIntervalSet_03(base.GetCppThis(), xmin, assoc, arrayName, component, allScalars);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddIntervalSet_04(HandleRef pThis, double xmin, double xmax, int omin, int omax, int assoc, string arrayName, int component, int allScalars);

		public int AddIntervalSet(double xmin, double xmax, int omin, int omax, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddIntervalSet_04(base.GetCppThis(), xmin, xmax, omin, omax, assoc, arrayName, component, allScalars);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddIntervalSet_05(HandleRef pThis, double xmin, double xmax, int omin, int omax, int assoc, int attribType, int component, int allScalars);

		public int AddIntervalSet(double xmin, double xmax, int omin, int omax, int assoc, int attribType, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddIntervalSet_05(base.GetCppThis(), xmin, xmax, omin, omax, assoc, attribType, component, allScalars);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddLowpassIntervalSet_06(HandleRef pThis, double xmax, int assoc, string arrayName, int component, int allScalars);

		public int AddLowpassIntervalSet(double xmax, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddLowpassIntervalSet_06(base.GetCppThis(), xmax, assoc, arrayName, component, allScalars);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_AddNotchIntervalSet_07(HandleRef pThis, double xlo, double xhi, int assoc, string arrayName, int component, int allScalars);

		public int AddNotchIntervalSet(double xlo, double xhi, int assoc, string arrayName, int component, int allScalars)
		{
			return vtkMultiThreshold.vtkMultiThreshold_AddNotchIntervalSet_07(base.GetCppThis(), xlo, xhi, assoc, arrayName, component, allScalars);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiThreshold.vtkMultiThreshold_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiThreshold.vtkMultiThreshold_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiThreshold_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiThreshold NewInstance()
		{
			vtkMultiThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiThreshold.vtkMultiThreshold_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMultiThreshold_OutputSet_12(HandleRef pThis, int setId);

		public int OutputSet(int setId)
		{
			return vtkMultiThreshold.vtkMultiThreshold_OutputSet_12(base.GetCppThis(), setId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMultiThreshold_Reset_13(HandleRef pThis);

		public void Reset()
		{
			vtkMultiThreshold.vtkMultiThreshold_Reset_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiThreshold_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkMultiThreshold vtkMultiThreshold = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiThreshold.vtkMultiThreshold_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiThreshold = (vtkMultiThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiThreshold.Register(null);
				}
			}
			return vtkMultiThreshold;
		}
	}
}
