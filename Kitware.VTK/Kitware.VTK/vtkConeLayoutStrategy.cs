using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConeLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConeLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkConeLayoutStrategy()
		{
			vtkConeLayoutStrategy.MRClassNameKey = "class vtkConeLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConeLayoutStrategy"));
		}

		public vtkConeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConeLayoutStrategy New()
		{
			vtkConeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConeLayoutStrategy.vtkConeLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConeLayoutStrategy.vtkConeLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConeLayoutStrategy_CompressionOff_01(HandleRef pThis);

		public virtual void CompressionOff()
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_CompressionOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConeLayoutStrategy_CompressionOn_02(HandleRef pThis);

		public virtual void CompressionOn()
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_CompressionOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkConeLayoutStrategy_GetCompactness_03(HandleRef pThis);

		public virtual float GetCompactness()
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetCompactness_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConeLayoutStrategy_GetCompression_04(HandleRef pThis);

		public virtual int GetCompression()
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetCompression_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkConeLayoutStrategy_GetSpacing_05(HandleRef pThis);

		public virtual float GetSpacing()
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetSpacing_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConeLayoutStrategy_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConeLayoutStrategy_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConeLayoutStrategy_Layout_08(HandleRef pThis);

		public override void Layout()
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_Layout_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConeLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConeLayoutStrategy NewInstance()
		{
			vtkConeLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConeLayoutStrategy.vtkConeLayoutStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConeLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkConeLayoutStrategy vtkConeLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConeLayoutStrategy.vtkConeLayoutStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConeLayoutStrategy = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConeLayoutStrategy.Register(null);
				}
			}
			return vtkConeLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConeLayoutStrategy_SetCompactness_12(HandleRef pThis, float _arg);

		public virtual void SetCompactness(float _arg)
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_SetCompactness_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConeLayoutStrategy_SetCompression_13(HandleRef pThis, int _arg);

		public virtual void SetCompression(int _arg)
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_SetCompression_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConeLayoutStrategy_SetSpacing_14(HandleRef pThis, float _arg);

		public virtual void SetSpacing(float _arg)
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_SetSpacing_14(base.GetCppThis(), _arg);
		}
	}
}
