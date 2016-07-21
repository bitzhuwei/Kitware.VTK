using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDotProductSimilarity : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDotProductSimilarity";

		public new static readonly string MRClassNameKey;

		static vtkDotProductSimilarity()
		{
			vtkDotProductSimilarity.MRClassNameKey = "class vtkDotProductSimilarity";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDotProductSimilarity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDotProductSimilarity"));
		}

		public vtkDotProductSimilarity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDotProductSimilarity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDotProductSimilarity New()
		{
			vtkDotProductSimilarity result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDotProductSimilarity.vtkDotProductSimilarity_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDotProductSimilarity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDotProductSimilarity.vtkDotProductSimilarity_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_GetDiagonal_01(HandleRef pThis);

		public virtual int GetDiagonal()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetDiagonal_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_GetFirstSecond_02(HandleRef pThis);

		public virtual int GetFirstSecond()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetFirstSecond_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_GetLowerDiagonal_03(HandleRef pThis);

		public virtual int GetLowerDiagonal()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetLowerDiagonal_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkDotProductSimilarity_GetMaximumCount_04(HandleRef pThis);

		public virtual long GetMaximumCount()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetMaximumCount_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkDotProductSimilarity_GetMinimumCount_05(HandleRef pThis);

		public virtual long GetMinimumCount()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetMinimumCount_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkDotProductSimilarity_GetMinimumThreshold_06(HandleRef pThis);

		public virtual double GetMinimumThreshold()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetMinimumThreshold_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_GetSecondFirst_07(HandleRef pThis);

		public virtual int GetSecondFirst()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetSecondFirst_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_GetUpperDiagonal_08(HandleRef pThis);

		public virtual int GetUpperDiagonal()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetUpperDiagonal_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkDotProductSimilarity_GetVectorDimension_09(HandleRef pThis);

		public virtual long GetVectorDimension()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetVectorDimension_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDotProductSimilarity_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDotProductSimilarity_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDotProductSimilarity NewInstance()
		{
			vtkDotProductSimilarity result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDotProductSimilarity.vtkDotProductSimilarity_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDotProductSimilarity_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDotProductSimilarity SafeDownCast(vtkObjectBase o)
		{
			vtkDotProductSimilarity vtkDotProductSimilarity = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDotProductSimilarity.vtkDotProductSimilarity_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDotProductSimilarity = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDotProductSimilarity.Register(null);
				}
			}
			return vtkDotProductSimilarity;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetDiagonal_15(HandleRef pThis, int _arg);

		public virtual void SetDiagonal(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetDiagonal_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetFirstSecond_16(HandleRef pThis, int _arg);

		public virtual void SetFirstSecond(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetFirstSecond_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetLowerDiagonal_17(HandleRef pThis, int _arg);

		public virtual void SetLowerDiagonal(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetLowerDiagonal_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetMaximumCount_18(HandleRef pThis, long _arg);

		public virtual void SetMaximumCount(long _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetMaximumCount_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetMinimumCount_19(HandleRef pThis, long _arg);

		public virtual void SetMinimumCount(long _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetMinimumCount_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetMinimumThreshold_20(HandleRef pThis, double _arg);

		public virtual void SetMinimumThreshold(double _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetMinimumThreshold_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetSecondFirst_21(HandleRef pThis, int _arg);

		public virtual void SetSecondFirst(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetSecondFirst_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetUpperDiagonal_22(HandleRef pThis, int _arg);

		public virtual void SetUpperDiagonal(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetUpperDiagonal_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDotProductSimilarity_SetVectorDimension_23(HandleRef pThis, long _arg);

		public virtual void SetVectorDimension(long _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetVectorDimension_23(base.GetCppThis(), _arg);
		}
	}
}
