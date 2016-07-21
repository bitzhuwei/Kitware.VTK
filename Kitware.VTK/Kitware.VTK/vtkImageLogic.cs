using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageLogic : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLogic";

		public new static readonly string MRClassNameKey;

		static vtkImageLogic()
		{
			vtkImageLogic.MRClassNameKey = "class vtkImageLogic";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLogic.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLogic"));
		}

		public vtkImageLogic(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLogic_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageLogic New()
		{
			vtkImageLogic result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLogic.vtkImageLogic_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageLogic() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageLogic.vtkImageLogic_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLogic_GetOperation_01(HandleRef pThis);

		public virtual int GetOperation()
		{
			return vtkImageLogic.vtkImageLogic_GetOperation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageLogic_GetOutputTrueValue_02(HandleRef pThis);

		public virtual double GetOutputTrueValue()
		{
			return vtkImageLogic.vtkImageLogic_GetOutputTrueValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLogic_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageLogic.vtkImageLogic_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLogic_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageLogic.vtkImageLogic_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLogic_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageLogic NewInstance()
		{
			vtkImageLogic result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLogic.vtkImageLogic_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLogic_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageLogic SafeDownCast(vtkObjectBase o)
		{
			vtkImageLogic vtkImageLogic = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLogic.vtkImageLogic_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLogic = (vtkImageLogic)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLogic.Register(null);
				}
			}
			return vtkImageLogic;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetInput1_08(HandleRef pThis, HandleRef input);

		public virtual void SetInput1(vtkDataObject input)
		{
			vtkImageLogic.vtkImageLogic_SetInput1_08(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetInput2_09(HandleRef pThis, HandleRef input);

		public virtual void SetInput2(vtkDataObject input)
		{
			vtkImageLogic.vtkImageLogic_SetInput2_09(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperation_10(HandleRef pThis, int _arg);

		public virtual void SetOperation(int _arg)
		{
			vtkImageLogic.vtkImageLogic_SetOperation_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperationToAnd_11(HandleRef pThis);

		public void SetOperationToAnd()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToAnd_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperationToNand_12(HandleRef pThis);

		public void SetOperationToNand()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToNand_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperationToNor_13(HandleRef pThis);

		public void SetOperationToNor()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToNor_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperationToNot_14(HandleRef pThis);

		public void SetOperationToNot()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToNot_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperationToOr_15(HandleRef pThis);

		public void SetOperationToOr()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToOr_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOperationToXor_16(HandleRef pThis);

		public void SetOperationToXor()
		{
			vtkImageLogic.vtkImageLogic_SetOperationToXor_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogic_SetOutputTrueValue_17(HandleRef pThis, double _arg);

		public virtual void SetOutputTrueValue(double _arg)
		{
			vtkImageLogic.vtkImageLogic_SetOutputTrueValue_17(base.GetCppThis(), _arg);
		}
	}
}
