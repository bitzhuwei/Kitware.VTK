using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInterpolateDataSetAttributes : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolateDataSetAttributes";

		public new static readonly string MRClassNameKey;

		static vtkInterpolateDataSetAttributes()
		{
			vtkInterpolateDataSetAttributes.MRClassNameKey = "class vtkInterpolateDataSetAttributes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolateDataSetAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolateDataSetAttributes"));
		}

		public vtkInterpolateDataSetAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInterpolateDataSetAttributes New()
		{
			vtkInterpolateDataSetAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInterpolateDataSetAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_GetInputList_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSetCollection GetInputList()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetInputList_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkInterpolateDataSetAttributes_GetT_02(HandleRef pThis);

		public virtual double GetT()
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetT_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkInterpolateDataSetAttributes_GetTMaxValue_03(HandleRef pThis);

		public virtual double GetTMaxValue()
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetTMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkInterpolateDataSetAttributes_GetTMinValue_04(HandleRef pThis);

		public virtual double GetTMinValue()
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_GetTMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkInterpolateDataSetAttributes_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkInterpolateDataSetAttributes_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInterpolateDataSetAttributes NewInstance()
		{
			vtkInterpolateDataSetAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkInterpolateDataSetAttributes_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInterpolateDataSetAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolateDataSetAttributes vtkInterpolateDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolateDataSetAttributes = (vtkInterpolateDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolateDataSetAttributes.Register(null);
				}
			}
			return vtkInterpolateDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkInterpolateDataSetAttributes_SetT_10(HandleRef pThis, double _arg);

		public virtual void SetT(double _arg)
		{
			vtkInterpolateDataSetAttributes.vtkInterpolateDataSetAttributes_SetT_10(base.GetCppThis(), _arg);
		}
	}
}
